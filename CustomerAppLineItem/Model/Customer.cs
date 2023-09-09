using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppLineItem.Model
{
    internal class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        List<Order> Orders { get; set; }

        public Customer(int id ,string name) 
        {
            Id = id;
            Name = name;    
            Orders = new List<Order>();
        }   
    }
}
