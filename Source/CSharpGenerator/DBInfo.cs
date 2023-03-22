using RepoDomain.Interfaces;

public class DBInfo : IDBInfo
{
    public List<ITable> Tables { get; set; }
}