using System;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // addresses
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Address address2 = new Address("456 Oak St", "Los Angeles", "CA", "USA");
            Address address3 = new Address("789 Elm St", "Toronto", "ON", "Canada");

            // customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);
            Customer customer3 = new Customer("Alice Johnson", address3);

            // products
            Product product1 = new Product("Product 1", "P001", 10.99m, 2);
            Product product2 = new Product("Product 2", "P002", 7.99m, 3);
            Product product3 = new Product("Product 3", "P003", 15.99m, 1);

            // orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // packing labels/ shipping labels/ total price
            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

            Console.WriteLine();

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
        }
    }
}
