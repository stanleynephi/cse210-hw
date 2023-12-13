using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        //new instatce for the productr
        Product prod = new Product();
        Console.WriteLine("What is the name of the product");
        string name = Console.ReadLine();
        Console.WriteLine("What is the amount of the product");
        int ammount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many quantities did you purchase?");
        int quantity = Convert.ToInt32(Console.ReadLine());

        prod.SetName(name);
        prod.SetQuantity(quantity);
        prod.SetPrice(ammount);
        Console.WriteLine(prod.TotalPrice());

        // new instance for the address
        Address addr = new Address();
        Console.WriteLine("What street are you on?");
        string street = Console.ReadLine();
        addr.SetStreet(street);
        Console.Write("City: ");
        string city = Console.ReadLine();
        addr.SetCity(city);
        Console.WriteLine("Country:");
        string country = Console.ReadLine();
        addr.SetCountry(country);
        Console.WriteLine(addr.GetAddress());

        //new instance for customer
        Console.WriteLine("what is your name? ");
        string name1 = Console.ReadLine();
        Customer cust = new Customer(addr,name1);
        Console.WriteLine(addr.getCountry());
        Console.WriteLine(cust.Country1());


        //new instance for order
        Order ordr = new Order(cust,prod);
        Console.WriteLine(ordr.Label());
        //add product to the product list
        ordr.AddItemToOrder(prod);
        // return total price
        Console.WriteLine("The total cost of your order is",ordr.TotalPrice());
        

    }
}