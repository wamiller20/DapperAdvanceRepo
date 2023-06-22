namespace MSSQLInfo
{
    public class ViewItem : ITableOrViewItem
    {
        public ViewItem()
        {
            SchemaName = String.Empty;
            ItemID = 0;
            ItemName = String.Empty;
        }

        public string TypeOfItem => "View";

        public string SchemaName { get; set; }

        public string ItemName { get; set; }

        public int ItemID { get; set; }

    }
}