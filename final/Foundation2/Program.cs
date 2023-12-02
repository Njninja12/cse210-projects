class Program
{
    static void Main()
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address internationalAddress = new Address("456 Foreign St", "Another City", "Province", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer internationalCustomer = new Customer("Jane Smith", internationalAddress);

        // Create products
        Product product1 = new Product("Widget", "W001", 10.99m, 2);
        Product product2 = new Product("Gadget", "G002", 19.99m, 1);

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2 }, usaCustomer);
        Order order2 = new Order(new List<Product> { product1 }, internationalCustomer);

        // Display results
        Console.WriteLine("Order 1 Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\n-----------------------------------------\n");

        Console.WriteLine("Order 2 Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Cost: $" + order2.CalculateTotalCost());
    }
}