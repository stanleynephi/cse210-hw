using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Hello Foundation3 World!");
        Address address = new Address("Kantamanto","Accra","Ghana");
        Lectures lectures = new Lectures("Programming with class", $"{address.GetAddress1()}","Write Codes Using C sharp" ,"Broher Curtis", 30, DateTime.Now.AddDays(7));
        string title = lectures.Gettitle();
        string details = lectures.Getdetails();
        Console.WriteLine(details);


        // for Recption
        Address address1 = new Address("Nungua", "Accra", "Ghana");
        Reception reception = new Reception("End of Year Xmas Party", $"{address1.GetAddress1()}", "To Celebrate the end of year xmas activity",DateTime.Now.AddDays(30), "Nuley Nephi", 0201172848);
        string rsvp = reception.GetRSVP();
        string details1 = reception.Getdetails();
        Console.WriteLine($"The RSVP is: {rsvp}");
        Console.WriteLine(details1);
    }
}