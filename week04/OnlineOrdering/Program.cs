using System;

class Program
{
     static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Main Street", "New York", "NY");
        Address address2 = new Address("456 Elm Avenue", "Los Angeles", "CA");
        Address address3 = new Address("789 Oak Drive", "Chicago", "IL");

   
        Customer customer1 = new Customer("Emily Johnson", address1);
        Customer customer2 = new Customer("Sophia Martinez", address2);
        Customer customer3 = new Customer("Olivia Smith", address3);

        
        Product product1 = new Product("Lipstick", 101, 15.00m, 2);
        Product product2 = new Product("Foundation", 102, 25.00m, 1);
        Product product3 = new Product("Mascara", 103, 12.00m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);
      
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost():F2}");
    }
}