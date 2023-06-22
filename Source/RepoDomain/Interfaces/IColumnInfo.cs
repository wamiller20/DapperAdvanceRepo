using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDomain.Interfaces
{
    public interface IColumnInfo
    {
        string ColumnName { get; set; }
        string ColumnDataType { get; set; }
        bool PrimaryKey { get; set; }
        bool IsIdentity { get; set; }

    }
}
