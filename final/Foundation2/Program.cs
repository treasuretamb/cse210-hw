using System;

class Program
{
    static void Main(string[] args)
    {
         // Create address
        Address address1 = new Address
        {
            StreetAddress = "24 Graystone Avenue",
            City = "Sandton",
            State = "Gauteng",
            Country = "South Africa"
        };

        Address address2 = new Address
        {
            StreetAddress = "56 Minors Street",
            City = "Johannesburg",
            State = "Gauteng",
            Country = "South Africa"
        };

        // Create customers
        Customer customer1 = new Customer
        {
            Name = "Jake Civic",
            CustomerAddress = address1
        };

        Customer customer2 = new Customer
        {
            Name = "Lauren Moore",
            CustomerAddress = address2
        };

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Create products
        Product product1 = new Product
        {
            Name = "Kitchen Unit",
            ProductId = 1,
            Price = 10.0m,
            Quantity = 1
        };

        Product product2 = new Product
        {
            Name = "Groceries",
            ProductId = 2,
            Price = 20.0m,
            Quantity = 25
        };

        // Add products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2.AddProduct(product1);

        // Display order details
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());

        Console.ReadLine();
    }
}