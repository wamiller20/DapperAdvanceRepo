using RepoDomain.Interfaces;

public class ClassOutline
{
    protected readonly IDBInfo dbInfo;
    public string NameSpace;
    public string ClassName;
    public List<Field> Fields;
    public ITable TableInfo { get; set; }

    public ClassOutline(IDBInfo dbInfo, ITable tableInfo)
    {
        this.dbInfo = dbInfo;
        TableInfo = tableInfo;
        this.Setup();
    }

    public string GetClassOutline(ITable tableInfo)
    {
        
        return String.Empty;
    }

    protected void Setup()
    {
        this.NameSpace = $@"{this.dbInfo.DBName}Repo.Entities";
        this.TableInfo = this.TableInfo;
        this.ClassName = this.TableInfo.TableName;
        this.Fields = this.TableInfo.Columns.Select(x => new Field(x.ColumnDataType, x.ColumnName, x.PrimaryKey)).ToList();
    }
}