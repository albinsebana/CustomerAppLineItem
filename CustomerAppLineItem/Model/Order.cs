using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppLineItem.Model
{
    internal class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> Items { get; set; }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public Order(int id , DateTime date ) 
        {
            Id = id;
            Date = date;
            Items = new List<LineItem>();
        }
        public double CalculateOrderPrice()
        {
            double totalOrderPrice = 0.0;

            foreach (LineItem item in Items)
            {
                totalOrderPrice += item.CalculateLineItemCost();
            }

            return totalOrderPrice;

        }

    }

}
