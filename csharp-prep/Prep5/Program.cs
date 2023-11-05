using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");


        WelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


        // FUNCTION TO DISPLAY A WELCOME MESSAGE        

        static string WelcomeMessage()
        {
            Console.WriteLine("Welcome Home");
            return "Welcome Home";
        }


        // FUNCTION TO ASK THE USER FOR HIS NAME
        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

    Console.WriteLine($"{name}");
            return name;

        }


//FUNCTION TO ASK USER FOR HIS FAVOURITE NUMBER
        static int PromptUserNumber()
        {
            Console.WriteLine("Whats is your favourite number? ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }


        static void DisplayResult(string name, int result)
        {
            Console.WriteLine($"{name} the square of your favourite number is {result}");
        }


    }
}