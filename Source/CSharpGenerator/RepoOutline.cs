// See https://aka.ms/new-console-template for more information
using RepoDomain.Interfaces;

public class RepoOutline
{
    private string repoName;

    public RepoOutline(ITable table)
    {
       this.repoName = table.TableName;
       this.BuildCRUDOperations(table.Columns); 
    }

    private void BuildCRUDOperations(List<IColumn> columns)
    {
        throw new NotImplementedException();
        
        
    }
}