using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppLineItem.Model
{
    internal class Customer
    {
        public int CustomerId { get; set; } 
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id ,string name, List<Order> orders) 
        {
            CustomerId = id;
            Name = name;    
            Orders = orders;
        }
        public string CustomerInfo()
        {
            string customerInfo = $"Customer Id: {CustomerId}\n";
            customerInfo += $"Customer Name: {Name}\n";
            customerInfo += $"Total Orders: {Orders.Count}\n\n";
            
            for (int i = 0; i < Orders.Count; i++)
            {
                Order order = Orders[i];
                customerInfo += "LineItemId\tProductId\tProductName\tQuantity\tUnitPrice\tDiscount%\tUnitCostAfterDiscount\tTotalLineItemCost\n";
                foreach (var item in order.Items)
                {
                    var product = item.Product;
                    customerInfo += $"{item.Id}\t{product.PdtId,-12}\t{product.Name}\t" +
                        $"{item.Quantity,-8}\t{product.Price}\t{product.DicountPercent}%\t" +
                        $"{product.CalculateDiscountedPrice()}\t{item.CalculateLineItemCost()}\n";
                }
            
            }
            return customerInfo ;
        }
       

    }
}
