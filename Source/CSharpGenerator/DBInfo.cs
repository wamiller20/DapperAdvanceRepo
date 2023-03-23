using RepoDomain.Interfaces;

public class DBInfo : IDBInfo
{
    public List<ITable> Tables { get; set; }
    public string DBName { get; set; }
}