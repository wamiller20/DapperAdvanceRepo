using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerator.Interfaces
{
    public interface IDBInfo
    {
        public List<ITable> Tables { get; set; }
    }
}
