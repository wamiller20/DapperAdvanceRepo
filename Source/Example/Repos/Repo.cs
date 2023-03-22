using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoExample.Repos
{
    public class ConcreteRepo<T, TKey>
    {
        public T FindByKey(TKey keyForTable)
        {
            throw new NotImplementedException();
        }
    }
}
