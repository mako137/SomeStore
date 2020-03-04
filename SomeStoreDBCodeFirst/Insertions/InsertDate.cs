using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeStoreDBCodeFirst.Model;

namespace SomeStoreDBCodeFirst.Insertions
{
    class InsertDate
    {
        public StoreContext Store { get; set; }
        public InsertDate(StoreContext storeContext)
        {
            Store = storeContext;
        }
        void CreatDataBase()
        {

        }

        public void AddStatus1()
        {
            Store.Statuses.AddRange(new[]
            {
                new Status {Name = "Admin"},
                new Status {Name = "User"}
            });
            Store.SaveChanges();
        }
        public void AddGender2()
        {
            Store.Genders.AddRange(new[]
            {
                new Gender {Name = "Male"},
                new Gender {Name = "Female"},
                new Gender {Name = "Other"}
            });
            Store.SaveChanges();
        }
        public void AddUsers3()
        {
            Store.Users.AddRange(new[]
            {
                new User {Name = "John" , Email="1@m.com",
                    BirthDate = DateTime.Parse("12-12-2000"),
                    GenderId = 1, LastName="Doe",
                Login="A",
                Password="1",
                Money=1000,
                Phone="123123",
                StatusId = 2},
                new User {Name = "B" , Email="2@m.com",
                    BirthDate = DateTime.Parse("11-11-2000"),
                    GenderId = 1, LastName="A",
                Login="B",
                Password="1",
                Money=1000,
                Phone="123123",
                StatusId = 1},
            });
            Store.SaveChanges();
        }

        public void AddCountries4()
        {
            Store.Countries.AddRange(new[]
            {
                new Country {Name="USA"},
                new Country {Name="UA"},
                new Country {Name="UK"}
            });
            Store.SaveChanges();
        }

        public void AddCities5()
        {
            Store.Cities.AddRange(new[]
            {
                new City {Name="Rivne", CountryId = 1},
                new City {Name="London" , CountryId = 2},
                new City {Name="New York", CountryId = 3}
            });
            Store.SaveChanges();
        }
        //public void AddCategories6()
        //{
        //    Store.Categories.AddRange(new[]
        //    {
        //        new Category {Name="Rivne", CountryId = 1},
        //        new Category {Name="London" , CountryId = 2},
        //        new Category {Name="New York", CountryId = 3}
        //    });
        //    Store.SaveChanges();
        //}

    }
}
