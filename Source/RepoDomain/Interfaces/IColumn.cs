using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerator.Interfaces
{
    public class IColumn
    {
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public bool PrimaryKey { get; set; }

    }
}
