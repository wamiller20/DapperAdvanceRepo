using RepoDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQLInfo.Entities
{
    public class TableInfo : ITableInfo
    {
        public TableInfo()
        {
            this.Columns = new List<IColumnInfo>();
        }
        public string TableName { get; set; }
        public List<IColumnInfo> Columns { get; set; }
        public string SchemaName { get; set; }
    }
}
