using System.Collections.Generic;

namespace SomeStoreDBCodeFirst.Model
{
    public class Category
    {
        public Category()
        {
            Users = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Users { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}