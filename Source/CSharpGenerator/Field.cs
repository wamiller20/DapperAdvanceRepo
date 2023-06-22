// See https://aka.ms/new-console-template for more information
public class Field
{
    public Field(string columnDataType, string columnName, bool inPrimaryKey, bool isIdentity)
    {
        this.FieldType = columnDataType;
        this.FieldName = columnName;
        this.InPrimaryKey = inPrimaryKey;
        this.IsIdentity = isIdentity;
    }

    public string FieldType { get; }
    public string FieldName { get; }
    public bool InPrimaryKey { get; }
    public bool IsIdentity { get; }
}