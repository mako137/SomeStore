using System.Collections.Generic;

namespace SomeStoreDBCodeFirst.Model
{
    public class Gender
    {
        public Gender()
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