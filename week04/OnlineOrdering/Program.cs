using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("Joseph Smith", addr1);
        Customer cust2 = new Customer("Bruce Lee", addr2);

        // Create products
        Product prod1 = new Product("Hat", "A123", 1.75, 3);
        Product prod2 = new Product("Bag", "B456", 2.50, 5);
        Product prod3 = new Product("Chair", "C789", 7.25, 6);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod2);
        order2.AddProduct(prod3);

        // Display order info
        foreach (var order in new[] { order1, order2 })
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}