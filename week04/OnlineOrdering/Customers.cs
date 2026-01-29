using System;

// Customer class - Represents a customer with name and address
public class Customer
{
    // Private member variables (encapsulation)
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if customer lives in USA (delegates to Address)
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Getter for customer name
    public string GetName()
    {
        return _name;
    }

    // Getter for address
    public Address GetAddress()
    {
        return _address;
    }
}