using System;
Scriptures _scriptures = new Scriptures();
Questions _questions = new Questions();
Scriptures _removes = new Scriptures();

while(true){
    Console.WriteLine("1: View all scripture");
    Console.WriteLine("2: Memoeize a scripture");

    // read the user choice
    int choice = int.Parse(Console.ReadLine());
    
    // do loop
    if (choice == 1){
        // call an instance for the scripture
        string Verse = _scriptures.Verse();
        Console.WriteLine(Verse);
    }
    else if (choice == 2) {
        // call an instance for the question
        string Question = _questions.Choice();
        Console.WriteLine(Question);

        string end = Console.ReadLine();
        while (end != "quit"){
            string Verse = _scriptures.Verse();
            Console.WriteLine(Verse);
            end = Console.ReadLine();

        }
    }
    
}
