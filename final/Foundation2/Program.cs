using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating products
        Product product1 = new Product("Laptop", "P123", 1200, 1);
        Product product2 = new Product("Mouse", "P456", 20, 3);

        // Creating customer address
        Address customerAddress = new Address("123 Main St", "Anytown", "CA", "USA");

        // Creating customer
        Customer customer = new Customer("John Doe", customerAddress);

        // Creating order
        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Creating another order
        Order order2 = new Order(customer);
        order2.AddProduct(new Product("Keyboard", "P789", 50, 2));

        // Displaying packing label, shipping label, and total price for order 1
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine();

        // Displaying packing label, shipping label, and total price for order 2
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Price: $" + order2.CalculateTotalPrice());
    }
}
