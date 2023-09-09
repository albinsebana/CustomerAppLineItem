using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppLineItem.Model
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _dicountPercent;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public double DicountPercent
        {
            get{ return _dicountPercent; }
            set { _dicountPercent = value; }
        }

        public double CalculateDiscountedPrice()
        {
            double discountedPrice = _price - (_price * (_dicountPercent / 100.0));
            return discountedPrice;
        }

    }
}
