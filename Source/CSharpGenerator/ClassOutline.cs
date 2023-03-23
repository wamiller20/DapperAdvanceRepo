using RepoDomain.Extenstions;
using RepoDomain.Interfaces;
using System.Text;

public class ClassOutline
{
    protected readonly IDBInfo dbInfo;
    public string NameSpace;
    public string ClassName;
    public List<Field> Fields;
    public ITable TableInfo { get; set; }
    private string newLine = "\n\r";
    private string tab = "\t";

    public ClassOutline(IDBInfo dbInfo, ITable tableInfo)
    {
        this.dbInfo = dbInfo;
        TableInfo = tableInfo;
        this.Setup();
    }

    public string GetClassOutline()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.GetNamespace_Begin());
        sb.AppendLine(this.GetUsingStatements());
        sb.AppendLine(this.GetClass_Begin());
        sb.AppendLine(this.GetFields());
        sb.AppendLine(this.GetConstructor());
        sb.AppendLine(this.GetProperties());
        sb.AppendLine(this.GetClass_End());
        sb.AppendLine(this.GetNamespace_End());

        return sb.ToString();
    }

    protected void Setup()
    {
        this.NameSpace = $@"{this.dbInfo.DBName}Repo.Entities";
        this.TableInfo = this.TableInfo;
        this.ClassName = this.TableInfo.TableName;
        this.Fields = this.TableInfo.Columns.Select(x => new Field(x.ColumnDataType, x.ColumnName.FirstCharToUpperCase(), x.PrimaryKey)).ToList();
    }

    protected string GetNamespace_Begin()
    {
        return $"namespace {this.NameSpace}{newLine+tab+"{"}";
    }

    protected string GetNamespace_End()
    {
        return "}";
    }

    protected string GetUsingStatements()
    {
        return string.Empty;
    }

    protected string GetClass_Begin()
    {
        return $"{tab}public class {this.ClassName}: PropertyChanged";
    }

    protected string GetClass_End()
    {
        return tab + "}";
    }

    protected string GetFields()
    {
        var sb = new StringBuilder();
        var nonPrimaryKeyFields = this.Fields.Where(x => x.InPrimaryKey == false);
        foreach (var field in nonPrimaryKeyFields)
        {
            sb.AppendLine($"{tab + tab}private {field.FieldType} {field.FieldName.FirstCharToLowerCase()};");
        }
        return sb.ToString();
    }

    protected string GetConstructor()
    {
        return string.Empty;
    }

    protected string GetProperties()
    {
        var sb = new StringBuilder();
        var primaryKeyFields = this.Fields.Where(x => x.InPrimaryKey == true);
        foreach (var field in primaryKeyFields)
        {
            sb.AppendLine($"{tab + tab}public {field.FieldType} {field.FieldName.FirstCharToUpperCase()} {"{ get; set; }"}");
        }

        var nonPrimaryKeyFields = this.Fields.Where(x => x.InPrimaryKey == false);
        foreach (var field in nonPrimaryKeyFields)
        {
            sb.AppendLine($"{tab + tab}public {field.FieldType} {field.FieldName.FirstCharToLowerCase()}");
            sb.AppendLine(tab + tab + "{");
            sb.AppendLine(tab + tab + tab +"get { return this." + field.FieldName.FirstCharToLowerCase() + "; }");
            sb.AppendLine(tab + tab + tab + "set");
            sb.AppendLine(tab + tab + tab + "{");
            sb.AppendLine(tab + tab + tab + tab + "if (value != this." + field.FieldName.FirstCharToLowerCase() + ")");
            sb.AppendLine(tab + tab + tab + tab + "{");
            sb.AppendLine(tab + tab + tab + tab + tab + "this." + field.FieldName.FirstCharToLowerCase() + " = value;");
            sb.AppendLine(tab + tab + tab + tab + tab + "this.PropertyHasChanged();");
            sb.AppendLine(tab + tab + tab + tab + "}");
            sb.AppendLine(tab + tab + tab + "}");
            sb.AppendLine(tab + tab + "}");
        }
        return sb.ToString();

    }
}