
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

	// available inactive command for WithEncryptionSystemSql (interlocked)
	private static global::System.Data.SqlClient.SqlCommand? s___dapper__command_Samples_CustomOptions_input_cs_WithEncryptionSystemSql_8;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::SomeType WithEncryptionSystemSql(global::System.Data.SqlClient.SqlConnection connection, int id, string name)
	{
		// locals
		global::System.Data.SqlClient.SqlCommand? __dapper__command = null;
		global::System.Data.SqlClient.SqlDataReader? __dapper__reader = null;
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
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_CustomOptions_input_cs_WithEncryptionSystemSql_8, null)) is null)
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
			global::SomeType __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!.Read(__dapper__reader, ref __dapper__tokenBuffer);
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
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_CustomOptions_input_cs_WithEncryptionSystemSql_8, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for WithEncryptionSystemSql
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.SqlClient.SqlCommand __dapper__CreateCommand(global::System.Data.SqlClient.SqlConnection connection)
		{
			var command = new global::System.Data.SqlClient.SqlCommand(@"sproc", connection, null!, global::System.Data.SqlClient.SqlCommandColumnEncryptionSetting.ResultSetOnly);
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
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


	// available inactive command for WithEncryptionMicrosoftSql (interlocked)
	private static global::Microsoft.Data.SqlClient.SqlCommand? s___dapper__command_Samples_CustomOptions_input_cs_WithEncryptionMicrosoftSql_12;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::SomeType WithEncryptionMicrosoftSql(global::Microsoft.Data.SqlClient.SqlConnection connection, int id, string name)
	{
		// locals
		global::Microsoft.Data.SqlClient.SqlCommand? __dapper__command = null;
		global::Microsoft.Data.SqlClient.SqlDataReader? __dapper__reader = null;
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
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_CustomOptions_input_cs_WithEncryptionMicrosoftSql_12, null)) is null)
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
			global::SomeType __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.TypeReader.TryGetReader<global::SomeType>()!.Read(__dapper__reader, ref __dapper__tokenBuffer);
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
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_CustomOptions_input_cs_WithEncryptionMicrosoftSql_12, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for WithEncryptionMicrosoftSql
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::Microsoft.Data.SqlClient.SqlCommand __dapper__CreateCommand(global::Microsoft.Data.SqlClient.SqlConnection connection)
		{
			var command = new global::Microsoft.Data.SqlClient.SqlCommand(@"sproc", connection, null!, global::Microsoft.Data.SqlClient.SqlCommandColumnEncryptionSetting.Enabled);
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
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
