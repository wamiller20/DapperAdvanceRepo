// See https://aka.ms/new-console-template for more information
using RepoDomain.Interfaces;
using System.Text;

public class RepoOutline
{
    private string className;
    public string RepoName;
    private List<Method> methods;
    private List<IColumnInfo> columns;
    private string newLine = "\n\r";
    private string tab = "\t";
    private readonly ITableInfo tableInfo;
    private readonly IDBInfo dBInfo;

    public RepoOutline(IDBInfo dBInfo, ITableInfo table)
    {
        this.tableInfo = table;
        this.dBInfo = dBInfo;
    }

    protected virtual void Setup()
    {
        this.className = $"{this.tableInfo.TableName}Repo";
        this.RepoName = this.tableInfo.TableName + "Repo";
        this.methods = new List<Method>();
        this.columns = this.tableInfo.Columns;
        this.BuildCRUDOperations();
    }

    public string GetRepoOutline()
    {
        var classDeclaration = $"public class {className}\n";
        var classBody = "{\n";
        foreach (var method in methods)
        {
            classBody = $"{classBody}{method.ToString()}\n";
        }
        classBody.Append('}');

        return $"{classDeclaration}{classBody}";
    }

    private void BuildCRUDOperations()
    {
        this.BuildCreate();
        // this.BuildRead();
        // this.BuildUpdate();
        // this.BuildDelete();
    }

    private string GetCreateFunctionWithIdentity()
    {
        var sb = new StringBuilder();
        var parameterClassName = this.className.ToLower();
        methods.Add(new Method(){
            MethodName = "Create",
            ReturnType = this.className,
            Parameters = new List<Parameter>(new Parameter[]
            {
                new Parameter(){
                    ParameterName = parameterClassName,
                    ParameterType = this.className
                }
            }),
            Body = $@"var sql =
                ""INSERT INTO {this.RepoName} ({this.ColumnsToString()}) VALUES({this.ColumnsToParameters()}); "" +
                ""SELECT CAST(SCOPE_IDENTITY() as int)"";
            var id = this.db.Query<int>(sql, {parameterClassName}).Single();
            return {parameterClassName};"
        });
    }

    private void BuildRead()
    {
        throw new NotImplementedException();
    }

    private void BuildUpdate()
    {
        throw new NotImplementedException();
    }

    private void BuildDelete()
    {
        throw new NotImplementedException();
    }
        
    #region Helper Methods
    private string ColumnsToString()
    {
        return String.Join(',', columns.Select(x => x.ColumnName));
    }

    private string ColumnsToParameters()
    {
        return String.Join(',', columns.Select(x => $"@{x.ColumnName}"));
    }
    #endregion
}