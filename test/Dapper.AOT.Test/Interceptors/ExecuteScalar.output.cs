#nullable enable
file static class DapperGeneratedInterceptors
{
    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 13, 24)]
    internal static object? ExecuteScalar0(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, HasParameters, Scalar
        // takes parameter: <anonymous type: int Foo, string bar>
        global::System.Diagnostics.Debug.Assert(commandType is null);
        global::System.Diagnostics.Debug.Assert(param is not null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, commandType.GetValueOrDefault(), commandTimeout ?? -1, CommandFactory0.Instance).ExecuteScalar();

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 14, 24)]
    internal static object? ExecuteScalar1(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, StoredProcedure, Scalar
        global::System.Diagnostics.Debug.Assert(commandType == global::System.Data.CommandType.StoredProcedure);
        global::System.Diagnostics.Debug.Assert(param is null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, global::System.Data.CommandType.StoredProcedure, commandTimeout ?? -1, DefaultCommandFactory).ExecuteScalar();

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 15, 24)]
    internal static object? ExecuteScalar2(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, Text, Scalar
        global::System.Diagnostics.Debug.Assert(commandType == global::System.Data.CommandType.Text);
        global::System.Diagnostics.Debug.Assert(param is null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, global::System.Data.CommandType.Text, commandTimeout ?? -1, DefaultCommandFactory).ExecuteScalar();

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 17, 24)]
    internal static float ExecuteScalar3(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, TypedResult, HasParameters, Scalar
        // takes parameter: <anonymous type: int Foo, string bar>
        // returns data: float
        global::System.Diagnostics.Debug.Assert(commandType is null);
        global::System.Diagnostics.Debug.Assert(param is not null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, commandType.GetValueOrDefault(), commandTimeout ?? -1, CommandFactory0.Instance).ExecuteScalar<float>();

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 18, 24)]
    internal static float ExecuteScalar4(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, TypedResult, StoredProcedure, Scalar
        // returns data: float
        global::System.Diagnostics.Debug.Assert(commandType == global::System.Data.CommandType.StoredProcedure);
        global::System.Diagnostics.Debug.Assert(param is null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, global::System.Data.CommandType.StoredProcedure, commandTimeout ?? -1, DefaultCommandFactory).ExecuteScalar<float>();

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 19, 24)]
    internal static float ExecuteScalar5(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, TypedResult, Text, Scalar
        // returns data: float
        global::System.Diagnostics.Debug.Assert(commandType == global::System.Data.CommandType.Text);
        global::System.Diagnostics.Debug.Assert(param is null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, global::System.Data.CommandType.Text, commandTimeout ?? -1, DefaultCommandFactory).ExecuteScalar<float>();

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 21, 30)]
    internal static global::System.Threading.Tasks.Task<object>? ExecuteScalarAsync6(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, Async, HasParameters, Scalar
        // takes parameter: <anonymous type: int Foo, string bar>
        global::System.Diagnostics.Debug.Assert(commandType is null);
        global::System.Diagnostics.Debug.Assert(param is not null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, commandType.GetValueOrDefault(), commandTimeout ?? -1, CommandFactory0.Instance).ExecuteScalarAsync(default);

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 22, 30)]
    internal static global::System.Threading.Tasks.Task<object>? ExecuteScalarAsync7(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, Async, StoredProcedure, Scalar
        global::System.Diagnostics.Debug.Assert(commandType == global::System.Data.CommandType.StoredProcedure);
        global::System.Diagnostics.Debug.Assert(param is null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, global::System.Data.CommandType.StoredProcedure, commandTimeout ?? -1, DefaultCommandFactory).ExecuteScalarAsync(default);

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 23, 30)]
    internal static global::System.Threading.Tasks.Task<object>? ExecuteScalarAsync8(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, Async, Text, Scalar
        global::System.Diagnostics.Debug.Assert(commandType == global::System.Data.CommandType.Text);
        global::System.Diagnostics.Debug.Assert(param is null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, global::System.Data.CommandType.Text, commandTimeout ?? -1, DefaultCommandFactory).ExecuteScalarAsync(default);

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 25, 30)]
    internal static global::System.Threading.Tasks.Task<float> ExecuteScalarAsync9(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, Async, TypedResult, HasParameters, Scalar
        // takes parameter: <anonymous type: int Foo, string bar>
        // returns data: float
        global::System.Diagnostics.Debug.Assert(commandType is null);
        global::System.Diagnostics.Debug.Assert(param is not null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, commandType.GetValueOrDefault(), commandTimeout ?? -1, CommandFactory0.Instance).ExecuteScalarAsync<float>(default);

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 26, 30)]
    internal static global::System.Threading.Tasks.Task<float> ExecuteScalarAsync10(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, Async, TypedResult, StoredProcedure, Scalar
        // returns data: float
        global::System.Diagnostics.Debug.Assert(commandType == global::System.Data.CommandType.StoredProcedure);
        global::System.Diagnostics.Debug.Assert(param is null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, global::System.Data.CommandType.StoredProcedure, commandTimeout ?? -1, DefaultCommandFactory).ExecuteScalarAsync<float>(default);

    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\ExecuteScalar.input.cs", 27, 30)]
    internal static global::System.Threading.Tasks.Task<float> ExecuteScalarAsync11(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Execute, Async, TypedResult, Text, Scalar
        // returns data: float
        global::System.Diagnostics.Debug.Assert(commandType == global::System.Data.CommandType.Text);
        global::System.Diagnostics.Debug.Assert(param is null);

        return global::Dapper.DapperAotExtensions.Command<object?>(cnn, transaction, sql, param, global::System.Data.CommandType.Text, commandTimeout ?? -1, DefaultCommandFactory).ExecuteScalarAsync<float>(default);

    }

    private class CommonCommandFactory<T> : global::Dapper.CommandFactory<T>
    {
        public override global::System.Data.Common.DbCommand GetCommand(global::System.Data.Common.DbConnection connection, string sql, global::System.Data.CommandType commandType, T args)
        {
            var cmd = base.GetCommand(connection, sql, commandType, args);
            // apply special per-provider command initialization logic for OracleCommand
            if (cmd is global::Oracle.ManagedDataAccess.Client.OracleCommand cmd0)
            {
                cmd0.BindByName = true;
                cmd0.InitialLONGFetchSize = -1;

            }
            return cmd;
        }

    }

    private static readonly CommonCommandFactory<object?> DefaultCommandFactory = new();

    private sealed class CommandFactory0 : CommonCommandFactory<object?> // <anonymous type: int Foo, string bar>
    {
        internal static readonly CommandFactory0 Instance = new();
        private CommandFactory0() {}
        public override void AddParameters(global::System.Data.Common.DbCommand cmd, object? args)
        {
            // var sql = cmd.CommandText;
            // var commandType = cmd.CommandType;
            var typed = Cast(args, static () => new { Foo = default(int), bar = default(string)! }); // expected shape
            global::System.Data.Common.DbParameter p;
            // if (Include(sql, commandType, "Foo"))
            {
                p = cmd.CreateParameter();
                p.ParameterName = "Foo";
                p.DbType = global::System.Data.DbType.Int32;
                p.Value = AsValue(typed.Foo);
                cmd.Parameters.Add(p);
            }
            // if (Include(sql, commandType, "bar"))
            {
                p = cmd.CreateParameter();
                p.ParameterName = "bar";
                p.DbType = global::System.Data.DbType.String;
                p.Value = AsValue(typed.bar);
                cmd.Parameters.Add(p);
            }

        }
        public override void UpdateParameters(global::System.Data.Common.DbCommand cmd, object? args)
        {
            var sql = cmd.CommandText;
            var typed = Cast(args, static () => new { Foo = default(int), bar = default(string)! }); // expected shape
            var ps = cmd.Parameters;
            // if (Include(sql, commandType, "Foo"))
            {
                ps["Foo"].Value = AsValue(typed.Foo);

            }
            // if (Include(sql, commandType, "bar"))
            {
                ps["bar"].Value = AsValue(typed.bar);

            }

        }

    }


}
namespace System.Runtime.CompilerServices
{
    // this type is needed by the compiler to implement interceptors - it doesn't need to
    // come from the runtime itself, though

    [global::System.Diagnostics.Conditional("DEBUG")] // not needed post-build, so: evaporate
    [global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
    sealed file class InterceptsLocationAttribute : global::System.Attribute
    {
        public InterceptsLocationAttribute(string path, int lineNumber, int columnNumber)
        {
            _ = path;
            _ = lineNumber;
            _ = columnNumber;
        }
    }
}