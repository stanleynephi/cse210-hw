using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        //create a console.readline to allow the user enter his name
        Console.WriteLine("What is your name");
        string userName = Console.ReadLine();
        
        Console.WriteLine($"Welcome to the Health App Brother {userName} Where staying healthy is a prority");
        // let ask user what they want to do
        Console.WriteLine("Please select an option from the menu");
        Console.WriteLine("1. Breath Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listening Actibity");

        // read the users choice and convert to int
        int userChoice = int.Parse(Console.ReadLine());

        // switch cases based on choice
        switch(userChoice){
            case 1:
                // ask user for time to spend there
                Console.WriteLine("How long would you like to spend in the reflection activity?");
                int time = int.Parse(Console.ReadLine());
                // create a new object for the breath
                Breath breath = new Breath(userName,"Work on your Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", time);
                string breathname = breath.Getname();
                Console.WriteLine(breathname);
                breath.PerformBreathing();
                Console.WriteLine(breath.Farewell());
            break;

            case 2:
            // ask user for time to spend there
            Console.WriteLine("How long would you like to spend in the reflection activity?");
            int time1 = int.Parse(Console.ReadLine());
            // create a new object for the reflection
            Reflection reflection = new Reflection(userName, "Welcome to The Reflection Section", "Let help you reflect",time1);
            string reflectname = reflection.Getname();
            Console.WriteLine(reflectname);
            reflection.reflectionTime();
            Console.WriteLine(reflection.Farewell());
            
            break;

            case 3:
            // ask user for time to spend there
            Console.WriteLine("How long would you like to spend in the reflection activity?");
            int time2 = int.Parse(Console.ReadLine());
             // create a new object for the reflection
            Listening listening = new Listening(userName, "Welcome to The Reflection Section", "Let help you reflect",time2);
            string listeningname = listening.Getname();
            Console.WriteLine(listeningname);
            listening.ListeningTime();
            
            break;

            default : 
                Console.WriteLine("sorry wrong choice");
            break;
        }
    }
}