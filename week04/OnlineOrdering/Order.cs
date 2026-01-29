using System;
using System.Collections.Generic;

// Order class - Represents an order with products and customer
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); // Initialize the list
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate total cost (products + shipping)
    public double CalculateTotalCost()
    {
        double total = 0;

        // Sum up all product costs
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Adding shipping cost based on customer location
        if (_customer.IsInUSA())
        {
            total += 5.00; // USA shipping: $5
        }
        else
        {
            total += 35.00; // International shipping: $35
        }

        return total;
    }

    // Method to generate packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    // Method to generate shipping label
    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress();

        return label;
    }
}