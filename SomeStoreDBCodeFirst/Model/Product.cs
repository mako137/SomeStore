using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeStoreDBCodeFirst.Model
{
    public class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime DateOfProduction { get; set; }
        public DateTime DateOfExpire{ get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
