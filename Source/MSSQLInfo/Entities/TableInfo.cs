using RepoDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQLInfo.Entities
{
    public class TableInfo : ITable
    {
        public TableInfo()
        {
            this.Columns = new List<IColumn>();
        }
        public string TableName { get; set; }
        public List<IColumn> Columns { get; set; }
        public string SchemaName { get; set; }
    }
}
