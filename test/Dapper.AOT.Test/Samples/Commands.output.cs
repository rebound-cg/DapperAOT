// Output code has 24 diagnostics from 'Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs':
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(51,28): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(52,80): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(52,169): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(70,4): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(147,28): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(148,80): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(148,169): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(166,4): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(253,28): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(254,80): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(254,169): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(272,4): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(361,28): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(362,80): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(362,169): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(380,4): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(469,28): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(470,80): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(470,169): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(488,4): error CS0234: The type or namespace name 'TypeReader' does not exist in the namespace 'Dapper' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(532,52): error CS0535: '__dapper__SomeType_TypeReader' does not implement interface member 'ITypeReader<SomeType>.Read(DbDataReader, ReadOnlySpan<int>, int)'
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(544,27): error CS0161: '__dapper__SomeType_TypeReader.Read(DbDataReader, ReadOnlySpan<int>, int)': not all code paths return a value
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(544,52): error CS0234: The type or namespace name 'DbDataReader' does not exist in the namespace 'System.Data' (are you missing an assembly reference?)
// Dapper.AOT.Analyzers/Dapper.CodeAnalysis.CommandGenerator/Commands.output.cs(548,3): error CS1513: } expected

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

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
	public partial global::System.Collections.Generic.List<global::SomeType> AdHocCommandText(string sql, global::System.Data.Common.DbConnection connection, int id, string name)
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
			__dapper__command = __dapper__CreateCommand(connection!, sql);

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
				__dapper__command.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for AdHocCommandText
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection, string? commandText)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.Text;
			command.CommandText = commandText;
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


	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
	public partial global::System.Collections.Generic.List<global::SomeType> AdHocStoredProcedure(string sql, global::System.Data.Common.DbConnection connection, int id, string name)
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
			__dapper__command = __dapper__CreateCommand(connection!, sql);

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
				__dapper__command.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for AdHocStoredProcedure
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection, string? commandText)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = commandText;
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


	// available inactive command for ImplicitCommandText (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Commands_input_cs_ImplicitCommandText_14;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
	public partial global::System.Collections.Generic.List<global::SomeType> ImplicitCommandText(global::System.Data.Common.DbConnection connection, int id, string name)
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
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Commands_input_cs_ImplicitCommandText_14, null)) is null)
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
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Commands_input_cs_ImplicitCommandText_14, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ImplicitCommandText
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.Text;
			command.CommandText = @"/* Test.ImplicitCommandText, Samples/Commands.input.cs #14 */ this is CommandText";
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


	// available inactive command for ImplicitStoredProcedure (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Commands_input_cs_ImplicitStoredProcedure_17;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
	public partial global::System.Collections.Generic.List<global::SomeType> ImplicitStoredProcedure(global::System.Data.Common.DbConnection connection, int id, string name)
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
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Commands_input_cs_ImplicitStoredProcedure_17, null)) is null)
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
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Commands_input_cs_ImplicitStoredProcedure_17, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ImplicitStoredProcedure
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
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


	// available inactive command for ExplicitStoredProcedure (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Commands_input_cs_ExplicitStoredProcedure_20;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
	public partial global::System.Collections.Generic.List<global::SomeType> ExplicitStoredProcedure(global::System.Data.Common.DbConnection connection, int id, string name)
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
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Commands_input_cs_ExplicitStoredProcedure_20, null)) is null)
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
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Commands_input_cs_ExplicitStoredProcedure_20, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ExplicitStoredProcedure
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		[global::System.Runtime.CompilerServices.SkipLocalsInitAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"this is StoredProc";
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

namespace Dapper.Internal.__dapper__Run_TypeReaders
{
	file sealed class __dapper__SomeType_TypeReader : global::Dapper.ITypeReader<global::SomeType>
	{
		private __dapper__SomeType_TypeReader() { }
		public static readonly __dapper__SomeType_TypeReader Instance = new();

		public int GetToken(string columnName)
		{
			return -1;
		}

		public int GetToken(int token, global::System.Type type, bool isNullable) => token;

		public global::SomeType Read(global::System.Data.DbDataReader reader, global::System.ReadOnlySpan<int> tokens, int columnOffset)
		{
			global::SomeType obj = new();
		}
	}
	#endregion
