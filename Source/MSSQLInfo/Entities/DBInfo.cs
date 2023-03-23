using RepoDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQLInfo.Entities
{
    public class DBInfo : IDBInfo
    {
        public DBInfo()
        {
            this.Tables = new List<ITable>();
        }

        public List<ITable> Tables { get; set; }
        public string DBName { get; set; }
    }
}
