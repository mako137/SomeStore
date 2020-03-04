using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeStoreDBCodeFirst.Model
{
    public class Status
    {
        public Status()
        {
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
