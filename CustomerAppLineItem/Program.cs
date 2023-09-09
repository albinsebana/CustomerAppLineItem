using CustomerAppLineItem.Model;

namespace CustomerAppLineItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Product> products = new List<Product>();

            Product product1 = new Product
            {
                Id = 1,
                Name = "Soap",
                Price = 100.0,
                DicountPercent = 10.0
            };
            products.Add(product1);

            Product product2 = new Product
            {
                Id = 2,
                Name = "HeadPhone",
                Price = 2350.0,
                DicountPercent = 12.0
            };
            products.Add(product2);
            foreach (Product product in products)
            {
                Console.WriteLine("\nProduct Details:");
                Console.WriteLine("Product ID: " + product.Id);
                Console.WriteLine("Product Name: " + product.Name);
                Console.WriteLine("Product Price: RS : " + product.Price);
                Console.WriteLine("Discount Percent: " + product.DicountPercent + "%");
                Console.WriteLine(" Price After Discount: RS : " + product.CalculateDiscountedPrice());
            }
            LineItem lineItem = new LineItem(1, 3, product1);

            
            Console.WriteLine($"\n\nProduct Id:{product1.Id} | " +
                $"Product Name: {product1.Name} | Quantity : {lineItem.Quantity} |" +
                $"Discount :{product1.DicountPercent}% |" +
                $" Unit Cost After Discount :{product1.CalculateDiscountedPrice()}| " +
                $"Total Line Item Cost : {lineItem.CalculateLineItemCost()}");
        }
    }
}