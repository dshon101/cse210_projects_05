using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Address 1 (USA customer)
        Address address1 = new Address("123 Main Street", "Springfield", "IL", "USA");

        // Create Customer 1
        Customer customer1 = new Customer("John Smith", address1);

        // Create Order 1
        Order order1 = new Order(customer1);

        // Add products to Order 1
        Product product1 = new Product("Laptop", "TECH-001", 1200.00, 1);
        Product product2 = new Product("Wireless Mouse", "TECH-015", 25.00, 2);
        Product product3 = new Product("USB-C Cable", "TECH-022", 15.00, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create Address 2 (International customer)
        Address address2 = new Address("45 Queen Street", "Toronto", "ON", "Canada");

        // Create Customer 2
        Customer customer2 = new Customer("Sarah Johnson", address2);

        // Create Order 2
        Order order2 = new Order(customer2);

        // Add products to Order 2
        Product product4 = new Product("Mechanical Keyboard", "TECH-030", 150.00, 1);
        Product product5 = new Product("Monitor Stand", "DESK-005", 45.00, 2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Create Address 3 (Another USA customer)
        Address address3 = new Address("789 Oak Avenue", "Austin", "TX", "USA");

        // Create Customer 3
        Customer customer3 = new Customer("Michael Chen", address3);

        // Create Order 3
        Order order3 = new Order(customer3);

        // Add products to Order 3
        Product product6 = new Product("Noise-Canceling Headphones", "AUDIO-012", 280.00, 1);
        Product product7 = new Product("Webcam", "TECH-050", 95.00, 1);
        Product product8 = new Product("Laptop Bag", "ACC-025", 55.00, 1);

        order3.AddProduct(product6);
        order3.AddProduct(product7);
        order3.AddProduct(product8);

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine();

        // Display Order 3
        Console.WriteLine("===== ORDER 3 =====");
        Console.WriteLine();
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalCost():F2}");
        Console.WriteLine();
        Console.WriteLine("========================================");
    }
}