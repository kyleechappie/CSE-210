//COMPLETE

//Make sure that all member variables are private and getters, setters, and constructors are created as needed.
//Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.




using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");
        //order 1 
        Address address1 = new Address ("221b Baker St.", "London", "London", "United Kingdom");
        Customer customer1 = new Customer("Sherlock Holmes", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Black Tea", "1235", 7.25, 1);
        Product order1Product2 = new Product("Pipe Tabacco", "4678", 3.29, 28);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        //display order 1
        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);


        Console.WriteLine("----------------------------------------------------");


        //order 2
        Address address2 = new Address ("2 Willow Lane", "Pelican Town", "Stardew Valley", "USA");
        Customer customer2 = new Customer("Haley Caddel", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Pink Skirt", "1234", 57.00, 1);
        Product order2Product2 = new Product("Sunflower", "5678", 5.00, 7);
        Product order2Product3 = new Product("Pink Cake Dry Mix", "4029", 2.99, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        //shipping/paking
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("----------------------------------------------------");

    }   
}