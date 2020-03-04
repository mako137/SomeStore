using System;
using System.Collections;
using System.Collections.Generic;

namespace SomeStoreDBCodeFirst.Model
{
    public class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }

        public int StatusId { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public int  Money { get; set; }
        
        
        public int GenderId { get; set; }
        public virtual Status Status { get; set; }
        public virtual Gender Gender { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}