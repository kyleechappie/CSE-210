//Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
//The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
//This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
//A packing label should list the name and product id of each product in the order.
//A shipping label should list the name and address of the customer

using System;
using System.Collections.Generic;
using System.Text;

namespace ProductOrderingSystem
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var product in products)
            {
                totalCost += product.TotalCost();
            }
            totalCost += customer.IsInUSA() ? 5 : 35; // Shipping cost
            return totalCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder();
            foreach (var product in products)
            {
                packingLabel.AppendLine($"Product: {product.Name}, ID: {product.ProductId}");
            }
            return packingLabel.ToString();
        }

        public string GetShippingLabel()
        {
            StringBuilder shippingLabel = new StringBuilder();
            shippingLabel.AppendLine($"Customer: {customer.Name}");
            shippingLabel.AppendLine("Address:");
            shippingLabel.Append(customer.Address.ToString());
            return shippingLabel.ToString();
        }
    }
}
