using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer = new Customer("John Doe", address);

        Product product1 = new Product("Laptop", "P123", 1200.99, 1);
        Product product2 = new Product("Mouse", "P124", 25.50, 2);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
    }
}