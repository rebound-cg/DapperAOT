
#nullable enable
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by:
//     Dapper.CodeAnalysis.CommandGenerator vN/A
// Changes to this file may cause incorrect behavior and
// will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#region Designer generated code
partial class Test
{

	// available inactive command for List (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_List_8;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Generic.List<global::SomeType> List(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		int[]? __dapper__tokenBuffer = null;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_List_8, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!;
				global::System.Span<int> __dapper__tokens = __dapper__reader.FieldCount <= global::Dapper.TypeReader.MaxStackTokens ? stackalloc int[__dapper__reader.FieldCount] : global::Dapper.TypeReader.RentSpan(ref __dapper__tokenBuffer, __dapper__reader.FieldCount);
				__dapper__parser.IdentifyFieldTokensFromSchema(__dapper__reader, __dapper__tokens);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser.Read(__dapper__reader, __dapper__tokens));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_List_8, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for List
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	// available inactive command for Array (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_Array_11;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::SomeType[] Array(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		int[]? __dapper__tokenBuffer = null;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_Array_11, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process single row
			global::SomeType[] __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.TypeReader.TryGetReader<global::SomeType[]>()!.Read(__dapper__reader, ref __dapper__tokenBuffer);
			}
			else
			{
				__dapper__result = default!;
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }
			return __dapper__result;

			// TODO: post-process parameters

		}
		finally
		{
			// cleanup
			global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_Array_11, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for Array
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	// available inactive command for IList (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_IList_14;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Generic.IList<global::SomeType> IList(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		int[]? __dapper__tokenBuffer = null;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_IList_14, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!;
				global::System.Span<int> __dapper__tokens = __dapper__reader.FieldCount <= global::Dapper.TypeReader.MaxStackTokens ? stackalloc int[__dapper__reader.FieldCount] : global::Dapper.TypeReader.RentSpan(ref __dapper__tokenBuffer, __dapper__reader.FieldCount);
				__dapper__parser.IdentifyFieldTokensFromSchema(__dapper__reader, __dapper__tokens);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser.Read(__dapper__reader, __dapper__tokens));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_IList_14, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for IList
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	// available inactive command for ICollection (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_ICollection_17;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Generic.ICollection<global::SomeType> ICollection(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		int[]? __dapper__tokenBuffer = null;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ICollection_17, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!;
				global::System.Span<int> __dapper__tokens = __dapper__reader.FieldCount <= global::Dapper.TypeReader.MaxStackTokens ? stackalloc int[__dapper__reader.FieldCount] : global::Dapper.TypeReader.RentSpan(ref __dapper__tokenBuffer, __dapper__reader.FieldCount);
				__dapper__parser.IdentifyFieldTokensFromSchema(__dapper__reader, __dapper__tokens);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser.Read(__dapper__reader, __dapper__tokens));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ICollection_17, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ICollection
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	// available inactive command for ImmutableArray (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableArray_20;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Immutable.ImmutableArray<global::SomeType> ImmutableArray(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		int[]? __dapper__tokenBuffer = null;
#pragma warning disable CS0618
		global::Dapper.Internal.Collector<global::SomeType> __dapper__result = default;
#pragma warning restore CS0618
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableArray_20, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process multiple rows
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!;
				global::System.Span<int> __dapper__tokens = __dapper__reader.FieldCount <= global::Dapper.TypeReader.MaxStackTokens ? stackalloc int[__dapper__reader.FieldCount] : global::Dapper.TypeReader.RentSpan(ref __dapper__tokenBuffer, __dapper__reader.FieldCount);
				__dapper__parser.IdentifyFieldTokensFromSchema(__dapper__reader, __dapper__tokens);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser.Read(__dapper__reader, __dapper__tokens));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return global::System.Collections.Immutable.ImmutableArray.Create<global::SomeType>(__dapper__result.GetBuffer(), 0, __dapper__result.Count);
		}
		finally
		{
			// cleanup
			global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
			__dapper__result.Dispose();
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableArray_20, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ImmutableArray
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	// available inactive command for ImmutableList (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableList_23;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Immutable.ImmutableList<global::SomeType> ImmutableList(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		int[]? __dapper__tokenBuffer = null;
#pragma warning disable CS0618
		global::Dapper.Internal.Collector<global::SomeType> __dapper__result = default;
#pragma warning restore CS0618
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableList_23, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process multiple rows
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!;
				global::System.Span<int> __dapper__tokens = __dapper__reader.FieldCount <= global::Dapper.TypeReader.MaxStackTokens ? stackalloc int[__dapper__reader.FieldCount] : global::Dapper.TypeReader.RentSpan(ref __dapper__tokenBuffer, __dapper__reader.FieldCount);
				__dapper__parser.IdentifyFieldTokensFromSchema(__dapper__reader, __dapper__tokens);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser.Read(__dapper__reader, __dapper__tokens));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			switch (__dapper__result.Count)
			{
				case 0:return global::System.Collections.Immutable.ImmutableList<global::SomeType>.Empty;
				case 1:return global::System.Collections.Immutable.ImmutableList.Create<global::SomeType>(__dapper__result[0]);
				default:return global::System.Collections.Immutable.ImmutableList.CreateRange<global::SomeType>(__dapper__result.Segment);
			}
		}
		finally
		{
			// cleanup
			global::Dapper.TypeReader.Return(ref __dapper__tokenBuffer);
			__dapper__result.Dispose();
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableList_23, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ImmutableList
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}
}
#endregion
