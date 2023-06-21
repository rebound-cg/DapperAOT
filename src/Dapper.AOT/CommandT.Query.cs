﻿using Dapper.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Dapper;

partial struct Command<TArgs>
{
    /// <summary>
    /// Reads rows from a query, optionally buffered
    /// </summary>
    public IEnumerable<TRow> Query<TRow>(TArgs args, bool buffered, [DapperAot] RowFactory<TRow>? rowFactory = null)
        => buffered ? QueryBuffered(args, rowFactory) : QueryUnbuffered(args, rowFactory);

    /// <summary>
    /// Reads buffered rows from a query
    /// </summary>
    public List<TRow> QueryBuffered<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null)
    {
        QueryState state = default;
        try
        {
            state.ExecuteReader(GetCommand(args), CommandBehavior.SingleResult | CommandBehavior.SequentialAccess);

            var results = new List<TRow>();
            if (state.Reader.Read())
            {
                var readWriteTokens = state.Reader.FieldCount <= MAX_STACK_TOKENS
                    ? CommandUtils.UnsafeSlice(stackalloc int[MAX_STACK_TOKENS], state.Reader.FieldCount)
                    : state.Lease();

                (rowFactory ??= RowFactory<TRow>.Default).Tokenize(state.Reader, readWriteTokens, 0);
                ReadOnlySpan<int> readOnlyTokens = readWriteTokens; // avoid multiple conversions
                do
                {
                    results.Add(rowFactory.Read(state.Reader, readOnlyTokens, 0));
                }
                while (state.Reader.Read());
                state.Return();
            }
            // consume entire results (avoid unobserved TDS error messages)
            while (state.Reader.NextResult()) { }
            PostProcessAndRecycle(ref state, args);
            return results;
        }
        finally
        {
            state.Dispose();
        }
    }

    /// <summary>
    /// Reads buffered rows from a query
    /// </summary>
    public async Task<List<TRow>> QueryBufferedAsync<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null, CancellationToken cancellationToken = default)
    {
        QueryState state = default;
        try
        {
            await state.ExecuteReaderAsync(GetCommand(args), CommandBehavior.SingleResult | CommandBehavior.SequentialAccess, cancellationToken);

            var results = new List<TRow>();
            if (await state.Reader.ReadAsync(cancellationToken))
            {
                (rowFactory ??= RowFactory<TRow>.Default).Tokenize(state.Reader, state.Lease(), 0);
                do
                {
                    results.Add(rowFactory.Read(state.Reader, state.Tokens, 0));
                }
                while (await state.Reader.ReadAsync(cancellationToken));
                state.Return();
            }
            // consume entire results (avoid unobserved TDS error messages)
            while (await state.Reader.NextResultAsync(cancellationToken)) { }
            PostProcessAndRecycle(ref state, args);
            return results;
        }
        finally
        {
            await state.DisposeAsync();
        }
    }

    /// <summary>
    /// Reads unbuffered rows from a query
    /// </summary>
    public async IAsyncEnumerable<TRow> QueryUnbufferedAsync<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        QueryState state = default;
        try
        {
            await state.ExecuteReaderAsync(GetCommand(args), CommandBehavior.SingleResult | CommandBehavior.SequentialAccess, cancellationToken);

            if (await state.Reader.ReadAsync(cancellationToken))
            {
                (rowFactory ??= RowFactory<TRow>.Default).Tokenize(state.Reader, state.Lease(), 0);
                do
                {
                    yield return rowFactory.Read(state.Reader, state.Tokens, 0);
                }
                while (await state.Reader.ReadAsync(cancellationToken));
                state.Return();
            }
            // consume entire results (avoid unobserved TDS error messages)
            while (await state.Reader.NextResultAsync(cancellationToken)) { }
            PostProcessAndRecycle(ref state, args);
        }
        finally
        {
            await state.DisposeAsync();
        }
    }

    /// <summary>
    /// Reads unbuffered rows from a query
    /// </summary>
    public IEnumerable<TRow> QueryUnbuffered<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null)
    {
        QueryState state = default;
        try
        {
            state.ExecuteReader(GetCommand(args), CommandBehavior.SingleResult | CommandBehavior.SequentialAccess);

            if (state.Reader.Read())
            {
                (rowFactory ??= RowFactory<TRow>.Default).Tokenize(state.Reader, state.Lease(), 0);
                do
                {
                    yield return rowFactory.Read(state.Reader, state.Tokens, 0);
                }
                while (state.Reader.Read());
                state.Return();
            }
            // consume entire results (avoid unobserved TDS error messages)
            while (state.Reader.NextResult()) { }
            PostProcessAndRecycle(ref state, args);
        }
        finally
        {
            state.Dispose();
        }
    }

    const int MAX_STACK_TOKENS = 64;

    // if we don't care if there's two rows, we can restrict to read one only
    static CommandBehavior SingleFlags(OneRowFlags flags)
        => (flags & OneRowFlags.ThrowIfMultiple) == 0
            ? CommandBehavior.SingleResult | CommandBehavior.SequentialAccess | CommandBehavior.SingleRow
            : CommandBehavior.SingleResult | CommandBehavior.SequentialAccess;

    private TRow? QueryOneRow<TRow>(
        TArgs args,
        OneRowFlags flags,
        RowFactory<TRow>? rowFactory)
    {
        QueryState state = default;
        try
        {
            state.ExecuteReader(GetCommand(args), SingleFlags(flags));

            TRow? result = default;
            if (state.Reader.Read())
            {
                var readWriteTokens = state.Reader.FieldCount <= MAX_STACK_TOKENS
                    ? CommandUtils.UnsafeSlice(stackalloc int[MAX_STACK_TOKENS], state.Reader.FieldCount)
                    : state.Lease();

                (rowFactory ??= RowFactory<TRow>.Default).Tokenize(state.Reader, readWriteTokens, 0);
                result = rowFactory.Read(state.Reader, readWriteTokens, 0);
                state.Return();

                if (state.Reader.Read())
                {
                    if ((flags & OneRowFlags.ThrowIfMultiple) != 0)
                    {
                        CommandUtils.ThrowMultiple();
                    }
                    while (state.Reader.Read()) { }
                }
            }
            else if ((flags & OneRowFlags.ThrowIfNone) != 0)
            {
                CommandUtils.ThrowNone();
            }

            // consume entire results (avoid unobserved TDS error messages)
            while (state.Reader.NextResult()) { }
            PostProcessAndRecycle(ref state, args);
            return result;
        }
        finally
        {
            state.Dispose();
        }
    }

    private async Task<TRow?> QueryOneRowAsync<TRow>(
        TArgs args,
        OneRowFlags flags,
        RowFactory<TRow>? rowFactory,
        CancellationToken cancellationToken)
    {
        QueryState state = default;

        try
        {
            await state.ExecuteReaderAsync(GetCommand(args), SingleFlags(flags), cancellationToken);

            TRow? result = default;
            if (await state.Reader.ReadAsync(cancellationToken))
            {
                (rowFactory ??= RowFactory<TRow>.Default).Tokenize(state.Reader, state.Lease(), 0);

                result = rowFactory.Read(state.Reader, state.Tokens, 0);
                state.Return();

                if (await state.Reader.ReadAsync(cancellationToken))
                {
                    if ((flags & OneRowFlags.ThrowIfMultiple) != 0)
                    {
                        CommandUtils.ThrowMultiple();
                    }
                    while (await state.Reader.ReadAsync(cancellationToken)) { }
                }
            }
            else if ((flags & OneRowFlags.ThrowIfNone) != 0)
            {
                CommandUtils.ThrowNone();
            }

            // consume entire results (avoid unobserved TDS error messages)
            while (await state.Reader.NextResultAsync(cancellationToken)) { }
            PostProcessAndRecycle(ref state, args);
            return result;
        }
        finally
        {
            await state.DisposeAsync();
        }
    }

    /// <summary>
    /// Reads exactly one row
    /// </summary>
    public TRow QuerySingle<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null)
        => QueryOneRow(args, OneRowFlags.ThrowIfNone | OneRowFlags.ThrowIfMultiple, rowFactory)!;

    /// <summary>
    /// Reads the first row returned
    /// </summary>
    public TRow QueryFirst<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null)
        => QueryOneRow(args, OneRowFlags.ThrowIfNone, rowFactory)!;

    /// <summary>
    /// Reads at most one row
    /// </summary>
    public TRow? QuerySingleOrDefault<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null)
        => QueryOneRow(args, OneRowFlags.ThrowIfMultiple, rowFactory);

    /// <summary>
    /// Reads the first row, if any are returned
    /// </summary>
    public TRow? QueryFirstOrDefault<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null)
        => QueryOneRow(args, OneRowFlags.None, rowFactory);

    /// <summary>
    /// Reads exactly one row
    /// </summary>
    public Task<TRow> QuerySingleAsync<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null, CancellationToken cancellationToken = default)
        => QueryOneRowAsync(args, OneRowFlags.ThrowIfNone | OneRowFlags.ThrowIfMultiple, rowFactory, cancellationToken)!;

    /// <summary>
    /// Reads the first row returned
    /// </summary>
    public Task<TRow> QueryFirstAsync<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null, CancellationToken cancellationToken = default)
        => QueryOneRowAsync(args, OneRowFlags.ThrowIfNone, rowFactory, cancellationToken)!;

    /// <summary>
    /// Reads at most one row
    /// </summary>
    public Task<TRow?> QuerySingleOrDefaultAsync<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null, CancellationToken cancellationToken = default)
        => QueryOneRowAsync(args, OneRowFlags.ThrowIfMultiple, rowFactory, cancellationToken);

    /// <summary>
    /// Reads the first row, if any are returned
    /// </summary>
    public Task<TRow?> QueryFirstOrDefaultAsync<TRow>(TArgs args, [DapperAot] RowFactory<TRow>? rowFactory = null, CancellationToken cancellationToken = default)
        => QueryOneRowAsync(args, OneRowFlags.None, rowFactory, cancellationToken);
}