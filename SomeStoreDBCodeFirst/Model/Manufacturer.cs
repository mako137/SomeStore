using System.Collections.Generic;

namespace SomeStoreDBCodeFirst.Model
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            Addresses = new HashSet<Address>();
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}