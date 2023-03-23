using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDomain.Interfaces
{
    public interface ITable
    {
        public string TableName { get; set; }
        public string SchemaName { get; set; }
        public List<IColumn> Columns { get; set; }

    }
}
