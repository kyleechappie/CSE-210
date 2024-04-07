//Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
//The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
//This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
//A packing label should list the name and product id of each product in the order.
//A shipping label should list the name and address of the customer

using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer {get; set;}

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateSubtotal() 
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            double productPrice = product.CalculatePrice();
            subtotal += productPrice;
        }
        subtotal = Math.Round(subtotal, 2);
        return subtotal;
    }

    public double CalculateTotal()
    {
        double total = Math.Round((CalculateSubtotal() + _customer.GetShippingCost()),2);
        return total;
    }

    public void DisplayCosts(double subtotal, double shippingCost, double totalCost)
    {   
        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine($"Shipping: ${shippingCost}");
        Console.WriteLine($"Total: ${totalCost}");
    }

    public void DisplayPackingLabel()
    {   
        Console.WriteLine("PACKING LABEL");
        foreach (Product product in _products)
        {
            product.DisplayProductDetails();
        }
        
    }
    public void DisplayShippingLabel()
    {   
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine("SHIP TO: ");
        _customer.DisplayCustomer();
    }

    
}