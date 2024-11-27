using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        //Clearing console
        Console.Clear();

        //Writing some text to style the screen
        Console.WriteLine("ONLINE ORDERING SYSTEM");
        Console.WriteLine("");

        //Setting everything to create 3 orders
        Order order1 = new Order("Chelsea Hardy","1439 Emeral Dreams Drive", "Durand", "IL", "USA");
        Order order2 = new Order("Bradley Ramsey","1595 Barnes Street", "Orlando", "FL", "USA");
        Order order3 = new Order("Laurence Hill","61 Grimsby Rd", "Cleethorpes", "North East Lincolnshire", "England");

        //Setting customers
        /*order1.SetCustomer("Chelsea Hardy");
        order2.SetCustomer("Bradley Ramsey");
        order3.SetCustomer("Laurence Hill");
        //Setting customers Addresses
        order1.SetCustomerAddress("1439 Emeral Dreams Drive", "Durand", "IL", "USA");
        order2.SetCustomerAddress("1595 Barnes Street", "Orlando", "FL", "USA");
        order3.SetCustomerAddress("61 Grimsby Rd", "Cleethorpes", "North East Lincolnshire", "England");*/

        //Setting Products for order 1
        order1.SetNewProduct("Small size shirts", "ORD PRT 353", 12.50, 2);
        order1.SetNewProduct("Medium size shirts", "ORD PRT 355", 15.25, 4);
        order1.SetNewProduct("Large size shirts", "ORD PRT 144", 27.00, 1);
        //Setting Products for order 2
        order2.SetNewProduct("Size 11 running shoes", "ORD PRT 422", 55.80, 1);
        order2.SetNewProduct("Men's cologne 5oz", "ORD PRT 233", 36.75, 2);
        //Setting Products for order 3
        order3.SetNewProduct("Label design software", "PF222-003-00", 107.25, 1);
        order3.SetNewProduct("Cable 6mts", "PF222-004-00", 5.75, 6);
        order3.SetNewProduct("Label printer", "PF222-005-00", 226.00, 2);

        //Creating shipping label
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("");
        Console.WriteLine(order1.PackingLabel());

        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("");
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine("");
        Console.WriteLine(order3.PackingLabel());

    }
}