using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Address address1 = new Address(
        "123 Main Street",
        "Miami",
        "Florida",
        "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Mouse", "101", 25, 2);
        Product product2 = new Product("Keyboard", "202", 50, 1);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("Total Price:");
        Console.WriteLine(order1.GetTotalPrice());

        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Address address2 = new Address(
        "1504 New City",
        "Itajaí",
        "Santa Catarina",
        "BR"
        );

        Customer customer2 = new Customer("Jonathan Mera", address2);

        Product product3 = new Product("NoteBook", "290", 34, 3);
        Product product4 = new Product("Headphones", "150", 20, 5);

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("Total Price:");
        Console.WriteLine(order2.GetTotalPrice());
    }
}