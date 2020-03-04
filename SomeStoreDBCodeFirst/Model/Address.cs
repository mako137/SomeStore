using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SomeStoreDBCodeFirst.Model
{
    public class Address
    {
        public int Id { get; set; }

        
       public int Manufacturer_Id { get; set; }


       // [ForeignKey(ManufacturerId)]
        public virtual Manufacturer Manufacturer { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}