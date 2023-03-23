// See https://aka.ms/new-console-template for more information
using RepoDomain.Interfaces;

public class RepoOutline
{
    private string className;
    private string repoName;
    private List<Method> methods;
    private List<IColumn> columns;

    public RepoOutline(string className, ITable table)
    {
        this.className = className;
        this.repoName = table.TableName + "Repo";
        this.methods = new List<Method>();
        this.columns = table.Columns;
        this.BuildCRUDOperations(); 
    }

    private void BuildCRUDOperations()
    {
        this.BuildCreate();
        // this.BuildRead();
        // this.BuildUpdate();
        // this.BuildDelete();
    }

    private void BuildCreate()
    {
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
                ""INSERT INTO {this.repoName} ({this.ColumnsToString()}) VALUES({this.ColumnsToParameters()}); "" +
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
    
    public override string ToString()
    {
       var classDeclaration = $"public class {className}\n";
       
       var classBody = "{\n";

       foreach(var method in methods)
       {
           classBody = $"{classBody}{method.ToString()}\n";
       }
       
       classBody.Append('}');
       
       return $"{classDeclaration}{classBody}";
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