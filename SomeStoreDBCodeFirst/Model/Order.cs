using System;
using System.Collections;
using System.Collections.Generic;

namespace SomeStoreDBCodeFirst.Model
{
    public class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public DateTime DateOfOrder { get; set; }
        public virtual Address Address { get; set; }
        public int AddressId { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}