using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


        //create a new list in C#
        List<int> numbers1 = new List<int>();

        int num = -1;
        int result = 0;


        while (num != 0)
        {
            Console.WriteLine("Please enter a number  ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers1.Add(num);
            }

            if (num == 0)
            {
                Console.WriteLine("The numbers you entered are: ");

                int maxnumber = numbers1.Max();
                foreach (int number in numbers1)
                {
                    Console.WriteLine(number);
                    result += number;
                }

                Console.WriteLine($"Your total was {result}");
                Console.WriteLine($"The Max number is {maxnumber}");
                Console.WriteLine($"The Total Number in the list is {numbers1.Count()}");

                float average = ((float) result)/numbers1.Count();
                Console.WriteLine($"Average of all numbers is {average}");

            }
        }  
    }
    
}