using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDomain.Interfaces
{
    public interface ITableInfo
    {
        public string TableName { get; set; }
        public string SchemaName { get; set; }
        public List<IColumnInfo> Columns { get; set; }

    }
}
