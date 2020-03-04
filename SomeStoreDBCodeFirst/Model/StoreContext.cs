namespace SomeStoreDBCodeFirst.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SomeStoreDBCodeFirst.ConfiguratorHelper;
    public class StoreContext : DbContext
    {
       
        public StoreContext()
            : base("name=StoreContext")
        {
            Database.SetInitializer<StoreContext>(new CreateDatabaseIfNotExists<StoreContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new OrderHelper());
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }

    }

}