using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TuplesInterface.CoreRepoLogic;

namespace TuplesInterface.Person
{
    public class Person_Key : PropertyChanged, IPerson_Key
    {
        public int BusinessEntityID { get; set; }
    }
}
