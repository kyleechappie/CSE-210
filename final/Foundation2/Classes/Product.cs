//Contains the name, product id, price per unit, and quantity of each product.
//The total cost of this product is computed by multiplying the price per unit and the quantity. If the price per unit was $3 and they bought 5, the product total cost would be $15.

using System;

public class Product
{
    private string _name {get; set;}
    private string _id {get; set;}
    private  double _price {get; set;}
    private int _quantity {get; set;}

//constructor be so careful
    public Product (string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return Math.Round((_price * _quantity),2);
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"{_name} ({_id}) => Total: ${CalculatePrice()}");
    }
}