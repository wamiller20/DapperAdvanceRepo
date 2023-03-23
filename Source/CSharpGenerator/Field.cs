// See https://aka.ms/new-console-template for more information
public class Field
{
    public Field(string columnDataType, string columnName, bool inPrimaryKey)
    {
        this.FieldType = columnDataType;
        this.FieldName = columnName;
        this.InPrimaryKey = inPrimaryKey;
    }

    public string FieldType { get; }
    public string FieldName { get; }
    public bool InPrimaryKey { get; }
}