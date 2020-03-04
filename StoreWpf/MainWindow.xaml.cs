using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SomeStoreDBCodeFirst.Model;
using SomeStoreDBCodeFirst;
using System.Data.Entity;

namespace StoreWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StoreContext storeContext = null;
        public MainWindow()
        {
            InitializeComponent();
            storeContext = new StoreContext();
            //storeContext.Users.Load();
            gridUsers.DataContext = (from obj in storeContext.Users
                                     select new
                                     {
                                         Name = obj.Name,
                                         Login = obj.Login,
                                         Email = obj.Email,
                                         Gender = obj.Gender
                                     }).ToList();
        }

        private void Orders_Clicked(object sender, MouseButtonEventArgs e)
        {
            gridOrders.DataContext = (from obj in storeContext.Orders
                                      select new
                                      {
                                          UserName = obj.User.Name,
                                          obj.DateOfOrder,
                                          City = obj.Address.City.Name,
                                          Country = obj.Address.City.Country.Name,
                                          Street = obj.Address.Buildings.FirstOrDefault(x => x.AddressId == obj.AddressId).StreetName,
                                          BuildingNumb = obj.Address.Buildings.FirstOrDefault(x => x.AddressId == obj.AddressId).NumbOfBuilding
                                      }).ToList();
        }

        private void Users_Clicked(object sender, MouseButtonEventArgs e)
        {
            gridUsers.DataContext = (from obj in storeContext.Users
                                     select new
                                     {
                                         Name = obj.Name,
                                         Login = obj.Login,
                                         Email = obj.Email,
                                         Gender = obj.Gender
                                     }).ToList();
        }

        private void Products_Clicked(object sender, MouseButtonEventArgs e)
        {
            gridProducts.DataContext = (from obj in storeContext.Products
                                        select new
                                        {
                                            ProdName = obj.Name,
                                            Price = obj.Price,
                                            Quantity = obj.Quantity,
                                            Manufacturer = obj.Manufacturer.Name
                                        }).ToList();
        }
    }
}
