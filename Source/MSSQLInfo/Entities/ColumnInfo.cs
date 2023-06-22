using RepoDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQLInfo.Entities
{
    public class ColumnInfo : IColumnInfo
    {
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public bool PrimaryKey { get; set; }
        public bool IsIdentity { get; set; }
    }
}
