namespace MSSQLInfo
{
    public interface ITableOrViewItem
    {
        string TypeOfItem { get; }

        string SchemaName { get; set; }

        string ItemName { get; set; }

        int ItemID { get; set; }
    }
}