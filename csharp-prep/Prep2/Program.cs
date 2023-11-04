using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");


        Console.WriteLine("");
        Console.WriteLine("What is your score?");
        string score = Console.ReadLine();

        int grade = int.Parse(score);

        if (grade >= 90)
        {
            string letter = "A";
            Console.WriteLine($"Your grade is {letter}");
        }

        else if (grade >= 80)
        {
            string letter = "B";
            Console.WriteLine($"Your grade is {letter}");
        }

        else if (grade >= 70)
        {
            string letter = "C";
            Console.WriteLine($"Your grade is {letter}");
        }

        else if (grade >= 60)
        {
            string letter = "D";
            Console.WriteLine($"Your grade is {letter}");
        }

        else if (grade < 60)
        {  
            string letter = "F";
            Console.WriteLine($"Your grade is {letter}");
        }


        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }

        else
        {
            Console.WriteLine("Try again next time");
        }
    }
}