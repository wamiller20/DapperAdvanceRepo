using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQLInfo.Entities
{
    public class TableItem : ITableOrViewItem
    {
        public TableItem()
        {
            SchemaName = String.Empty;
            ItemID = 0;
            ItemName = String.Empty;
        }

        public string TypeOfItem => "table";

        public string SchemaName { get; set; }

        public string ItemName { get; set; }

        public int ItemID { get; set; }
    }
}
