using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SomeStoreDBCodeFirst.Model;

namespace SomeStoreDBCodeFirst.ConfiguratorHelper
{
    public class OrderHelper: EntityTypeConfiguration<Order>
    {
        public OrderHelper()
        {
            HasMany(x => x.Products).WithMany(y => y.Orders);
        }

    }
}
