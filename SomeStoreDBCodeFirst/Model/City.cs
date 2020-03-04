using System.Collections;
using System.Collections.Generic;

namespace SomeStoreDBCodeFirst.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}