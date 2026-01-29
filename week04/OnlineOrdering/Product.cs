using System;

// Product class - Represents a product with name, ID, price, and quantity
public class Product
{
    // Private member variables (encapsulation)
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate total cost for this product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getter for product name
    public string GetName()
    {
        return _name;
    }

    // Getter for product ID
    public string GetProductId()
    {
        return _productId;
    }

    // Getter for price
    public double GetPrice()
    {
        return _price;
    }

    // Getter for quantity
    public int GetQuantity()
    {
        return _quantity;
    }
}