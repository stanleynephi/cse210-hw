using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomnumber = new Random();
        int number = randomnumber.Next(1,11);

        int guess = -1; 
        string again = "yes";
        //let the user guess the number
        while (guess != number && again == "yes") 
        {
            Console.WriteLine("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Too high! Try Again.");
            }

            else if (guess < number)
            {
                Console.WriteLine("Too low! Try Again.");
            }

            else
            {
                Console.WriteLine("That was a correct guess well done");
            }


            Console.WriteLine("Will you play again?");
            again = Console.ReadLine();
        }
    }
}