using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppLineItem.Model
{
    internal class LineItem
    {
        private int _id;
        private int _quantity;
        private Product _product;
        //List<LineItem> _items;

        public LineItem (int id, int quantity, Product product)
        {
            _id = id;
            _quantity = quantity;
            _product = product;
        }
        public int Id
        { 
            get { return _id; }
            set { _id = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public Product Product 
        {
            get { return _product; }
            set { _product = value; }
        }
        public double CalculateLineItemCost()
        {
            _product.Price = _product.CalculateDiscountedPrice() * _quantity;
            return _product.Price;
        }
    }
}
