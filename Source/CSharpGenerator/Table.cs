using RepoDomain.Interfaces;

public class Table : ITable
{
    public string TableName { get; set; }
    public List<IColumn> Columns { get; set; }
    public string SchemaName { get; set; }
}