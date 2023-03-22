using RepoDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQLInfo.Entities
{
    public class ColumnInfo : IColumn
    {
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public bool PrimaryKey { get; set; }
    }
}
