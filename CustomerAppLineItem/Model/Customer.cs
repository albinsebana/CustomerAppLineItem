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
        public double GetTotalOrderPrice()
        {
            double totalCost = 0;
            foreach (Order order in Orders)
            {
                totalCost += order.CalculateOrderPrice();
            }
            return totalCost;
        }
        public string CustomerInfo()
        {
            string customerInfo = $"Customer Id: {CustomerId}\n";
            customerInfo += $"Customer Name: {Name}\n";
            customerInfo += $"Total Orders: {Orders.Count}\n\n";
            
            for (int i = 0; i < Orders.Count; i++)
            {
                Order order = Orders[i];
                customerInfo += $"Order No. {i + 1}\n";
                customerInfo += $"Order Id: {order.Id}\n";
                customerInfo += $"Order Date: {order.Date}\n\n";

                customerInfo += "LineItmId|PdtId|PdtName|Qty|UnitPrice|DiscntIn%|UnitcostAfterDiscount|TotalLineItemCost\n";
                foreach (var item in order.Items)
                {
                    var product = item.Product;
                    customerInfo += $"{item.Id}\t{product.PdtId}\t{product.Name}\t" +
                        $"{item.Quantity}\t{product.Price}\t{product.DicountPercent}%\t" +
                        $"{product.CalculateDiscountedPrice()}\t\t\t{item.CalculateLineItemCost()}\n";
                }
                customerInfo += "\n";
                double orderCost = order.CalculateOrderPrice();
                customerInfo += $"Order Cost: {orderCost}";
                //customerInfo +=  orderCostLine + "\n\n";
            }
            return customerInfo ;
        }
       

    }
}
