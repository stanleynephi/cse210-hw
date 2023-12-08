using System.Diagnostics;
using System.Globalization;
using System.Net.Http.Headers;

public class Activity {
    // create a private string for the welcome message
    private string _name;

    private string _greeting;// greeting message

    private string _discription; // to describe the activity

    private string _farewell ="Goodbye See You Next Time"; // for the farewell



    public Activity(string name,string greeting, string discription){
        _name = name;
        _greeting = greeting;
        _discription = discription;
    }

    public string Getname(){
        return _name;
    }

    public string Greeting(){
        return _greeting;
    }

    public string Discription(){
        return _discription;
    }

    public string Farewell(){
        return _farewell;
        
    }

}





// breathing child class
public class Breath : Activity{

    private int _breathduration;

    public Breath(string name, string greeting, string discription, int breathduration): base(name,greeting,discription){
        _breathduration = breathduration;
    }

    public void PerformBreathing()
    {
        // Alternating messages for breathing in and out
        for (int i = 0; i < 5; i++) // Repeat the process 5 times for demonstration
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(_breathduration * 1000); // Pause for the specified duration

            Console.WriteLine("Breathe out...");
            Thread.Sleep(_breathduration * 1000); // Pause for the specified duration

            // Show countdown after each breath
            for (int j = _breathduration; j > 0; j--)
            {
                Console.WriteLine($"Get Ready In: {j} seconds");
                Thread.Sleep(1000); // Pause for 1 second
            }
        }

    }
}


public class Reflection: Activity{
    private List<string> _prompt = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless",
    };

    private List<string> _prompt1 = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you start?",
        "How did you feel when it was complete?",

    };

    private int _waittime;

    public Reflection(string name, string greeting, string discription, int waittime): base(name,greeting,discription){
        _waittime = waittime;
    }

    // display random prompt
    public string DisplayPrompt(){
        Random rand = new Random();
        int randomNumber = rand.Next(_prompt.Count);
        return _prompt[randomNumber];
    }

    public string DisplayPrompt1(){
        Random rand1 = new Random();
        int randomNumber1 = rand1.Next(_prompt1.Count);
        return _prompt1[randomNumber1];
    }

    public void reflectionTime(){
        Console.WriteLine(DisplayPrompt());
        Thread.Sleep(_waittime * 1000);
        // Pause for the specified duration
        Console.WriteLine(DisplayPrompt1());
        Thread.Sleep(_waittime * 1000);
        // Pause for the specified duration
        Console.WriteLine(DisplayPrompt1());
        Thread.Sleep(_waittime * 1000);
    }

}

public class Listening: Activity{
    private List<string> _listeners = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strength of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private int _waittime1;
    public Listening(string name, string greeting, string discription, int waittime): base(name,greeting,discription){
        _waittime1 = waittime;
    }

    public string DisplayListen(){
        Random rand = new Random();
        int randomNumber = rand.Next(_listeners.Count);
        return _listeners[randomNumber];
    }

    public void ListeningTime(){
        Console.WriteLine(DisplayListen());
        Thread.Sleep(_waittime1 * 1000);
        // Pause for the specified duration
        Console.WriteLine(DisplayListen());
        Thread.Sleep(_waittime1 * 1000);
        // Pause for the specified duration
        Console.WriteLine(DisplayListen());
    }
}
