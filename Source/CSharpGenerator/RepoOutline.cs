// See https://aka.ms/new-console-template for more information
using RepoDomain.Interfaces;

public class RepoOutline
{
    private string className;
    private string repoName;
    private List<Method> methods;

    public RepoOutline(string className, ITable table)
    {
        this.className = className;
        this.repoName = table.TableName + "Repo";
        this.methods = new List<Method>();
        this.BuildCRUDOperations(table.Columns); 
    }

    private void BuildCRUDOperations(List<IColumn> columns)
    {
        this.BuildCreate(columns);
        this.BuildRead(columns);
        this.BuildUpdate(columns);
        this.BuildDelete(columns);
    }

    private void BuildCreate(List<IColumn> columns)
    {
        methods.Add(new Method(){
            MethodName = "Create",
            ReturnType = this.className,
            Parameters = new List<Parameter>(new Parameter[]
            {
                new Parameter(){
                    ParameterName = this.className.ToLower(),
                    ParameterType = this.className
                }
            }),
            Body = ""
        });
    }

    private void BuildRead(List<IColumn> columns)
    {
        throw new NotImplementedException();
    }

    private void BuildUpdate(List<IColumn> columns)
    {
        throw new NotImplementedException();
    }

    private void BuildDelete(List<IColumn> columns)
    {
        throw new NotImplementedException();
    }
}