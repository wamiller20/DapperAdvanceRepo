using RepoExample.CoreRepoLogic;

namespace RepoExample.Entities
{
    public class Person_Key : PropertyChanged, IPerson_Key
    {
        public int BusinessEntityID { get; set; }
    }
}
