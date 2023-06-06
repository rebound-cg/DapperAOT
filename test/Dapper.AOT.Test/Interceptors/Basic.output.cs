
file static partial class DapperGeneratedInterceptors
{
#pragma warning disable CS0618

    // placeholder for per-provider setup rules
    static partial void InitCommand(global::System.Data.Common.DbCommand cmd);

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\Basic.input.cs", 27, 13)]
    internal static unsafe global::Foo.Customer QueryFirst0(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Query, TypedResult, HasParameters, Buffered, First
        // takes parameter: <anonymous type: double? Blap>
        // returns data: global::Foo.Customer
        global::System.Diagnostics.Debug.Assert(commandType is null);
        global::System.Diagnostics.Debug.Assert(param is not null);
        return global::Dapper.Internal.InterceptorHelpers.UnsafeQueryFirst(
            global::Dapper.Internal.InterceptorHelpers.TypeCheck(cnn), sql,
            global::Dapper.Internal.InterceptorHelpers.Reshape(param!, // transform anon-type
                static () => new { Blap = default(double?) }, // expected shape
                static args => args.Blap), // project to named type
            global::Dapper.Internal.InterceptorHelpers.TypeCheck(transaction),
            commandTimeout, &CommandBuilder, &ColumnTokenizer0, &RowReader0);

        static void CommandBuilder(global::System.Data.Common.DbCommand cmd, double? args)
        {
            InitCommand(cmd);
            cmd.CommandType = global::System.Data.CommandType.Text;
            var p = cmd.CreateParameter();
            p.ParameterName = "Blap";
            p.DbType = global::System.Data.DbType.Double;
            p.Value = global::Dapper.Internal.InterceptorHelpers.AsValue(args);
            cmd.Parameters.Add(p);

        }
    }

    [global::System.Runtime.CompilerServices.InterceptsLocationAttribute("Interceptors\\Basic.input.cs", 28, 13)]
    internal static unsafe global::Foo.Customer QueryFirst1(this global::System.Data.IDbConnection cnn, string sql, object param, global::System.Data.IDbTransaction transaction, int? commandTimeout, global::System.Data.CommandType? commandType)
    {
        // Query, TypedResult, HasParameters, Buffered, First
        // takes parameter: <anonymous type: int Foo, string bar>
        // returns data: global::Foo.Customer
        global::System.Diagnostics.Debug.Assert(commandType is null);
        global::System.Diagnostics.Debug.Assert(param is not null);
        return global::Dapper.Internal.InterceptorHelpers.UnsafeQueryFirst(
            global::Dapper.Internal.InterceptorHelpers.TypeCheck(cnn), sql,
            global::Dapper.Internal.InterceptorHelpers.Reshape(param!, // transform anon-type
                static () => new { Foo = default(int), bar = default(string) }, // expected shape
                static args => (args.Foo, args.bar) ), // project to named type
            global::Dapper.Internal.InterceptorHelpers.TypeCheck(transaction),
            commandTimeout, &CommandBuilder, &ColumnTokenizer0, &RowReader0);

        static void CommandBuilder(global::System.Data.Common.DbCommand cmd, (int Foo, string bar) args)
        {
            InitCommand(cmd);
            cmd.CommandType = global::System.Data.CommandType.Text;
            var p = cmd.CreateParameter();
            p.ParameterName = "Foo";
            p.DbType = global::System.Data.DbType.Int32;
            p.Value = global::Dapper.Internal.InterceptorHelpers.AsValue(args.Foo);
            cmd.Parameters.Add(p);
            p = cmd.CreateParameter();
            p.ParameterName = "bar";
            p.DbType = global::System.Data.DbType.String;
            p.Value = global::Dapper.Internal.InterceptorHelpers.AsValue(args.bar);
            cmd.Parameters.Add(p);

        }
    }

    private static void ColumnTokenizer0(global::System.Data.Common.DbDataReader reader, global::System.Span<int> tokens, int fieldOffset)
    {
        // tokenize global::Foo.Customer
        for (int i = 0; i < tokens.Length; i++)
        {
            int token = -1;
            var name = reader.GetName(fieldOffset);
            var type = reader.GetFieldType(fieldOffset);
            switch (global::Dapper.Internal.StringHashing.NormalizedHash(name))
            {
                case 4245442695U when global::Dapper.Internal.StringHashing.NormalizedEquals(name, "X"):
                    token = type == typeof(int) ? 0 : 3; // two tokens for right-typed and type-flexible
                    break;
                case 4228665076U when global::Dapper.Internal.StringHashing.NormalizedEquals(name, "Y"):
                    token = type == typeof(string) ? 1 : 4;
                    break;
                case 4278997933U when global::Dapper.Internal.StringHashing.NormalizedEquals(name, "Z"):
                    token = type == typeof(double?) ? 2 : 5;
                    break;

            }
            tokens[i] = token;
            fieldOffset++;

        }

    }
    private static global::Foo.Customer RowReader0(global::System.Data.Common.DbDataReader reader, global::System.ReadOnlySpan<int> tokens, int fieldOffset)
    {
        // parse global::Foo.Customer
        global::Foo.Customer result = new();
        foreach (var token in tokens)
        {
            switch (token)
            {
                case 0:
                    result.X = reader.GetInt32(fieldOffset);
                    break;
                case 3:
                    result.X = global::Dapper.Internal.InterceptorHelpers.GetValue<int>(reader, fieldOffset);
                    break;
                case 1:
                    result.Y = reader.GetString(fieldOffset);
                    break;
                case 4:
                    result.Y = global::Dapper.Internal.InterceptorHelpers.GetValue<string>(reader, fieldOffset);
                    break;
                case 2:
                    result.Z = reader.IsDBNull(fieldOffset) ? (double?)null : reader.GetDouble(fieldOffset);
                    break;
                case 5:
                    result.Z = reader.IsDBNull(fieldOffset) ? (double?)null : global::Dapper.Internal.InterceptorHelpers.GetValue<double>(reader, fieldOffset);
                    break;

            }
            fieldOffset++;

        }
        return result;

    }
    static partial void InitCommand(global::System.Data.Common.DbCommand cmd)
    {
        // apply special per-provider command initialization logic
        if (cmd is global::Oracle.ManagedDataAccess.Client.OracleCommand cmd0)
        {
            cmd0.BindByName = true;
            cmd0.InitialLONGFetchSize = -1;

        }
    }

#pragma warning restore CS0618
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
