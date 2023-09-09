using CustomerAppLineItem.Model;
using System.Collections.Generic;

namespace CustomerAppLineItem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Product chair = new Product(1, "Chair", 4444, 15);
            Product table = new Product(2, "Table", 11500, 10);
            Product door = new Product(3, "Door", 13550, 20);
            Product sink = new Product(4, "Sink", 10300, 10);



            LineItem lineItem1 = new LineItem(1, 3, chair);
            LineItem lineItem2 = new LineItem(2, 2, door);





            Order customerOrder1 = new Order(1, DateTime.Now, new List<LineItem> { lineItem1 , lineItem2 });



            

            Customer customer1 = new Customer(101, "Albin", new List<Order> { customerOrder1 });

            Console.WriteLine("Customer 1:");
            Console.WriteLine(customer1.CustomerInfo());

        }
    }
}