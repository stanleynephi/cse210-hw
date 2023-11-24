using System;

// call the prompt generator and then add a  new string to it
PromptGenerator _prompt = new PromptGenerator();
// call the journal 
Journals journals = new Journals();
// call entry
Entry entry = new Entry();
// call the date

while (true)
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Write a new entry.");
    Console.WriteLine("2. Display the journal.");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // call an instance and
            string quest = _prompt.Text();
            // convert quest to sting
            string questString = _prompt.ToString();
            // display the output
            Console.WriteLine(quest);
            // add prompt to entry
            // add entry to journal
            entry._text = Console.ReadLine();
            journals.Entries.Add(entry);
            // add the prompt to the entry
            // journals.Entries.Add(_prompt);

            break;
        case 2:
            // display the journal
            journals.EntryDisplay();
            break;

        case 3:
        // load the journal
            journals.lines = File.ReadAllLines("journal.txt");
            journals.ReadFromFile();
        break;
        case 4:
        // save the journal
            Console.WriteLine("Enter the file name");
            string saveFileName = Console.ReadLine();
            journals.SaveToFile("Journal.txt");
            break;
    }
}
