using System;
using System.Collections.Generic;
using System.IO;

public class Journals
{
    // create a list data using entry as datatype
    // create a contante file name for the journal.
    private const string FileName = "journal.txt";
    public string [] lines;
    // creating list data for entries
    public List<Entry> Entries = new List<Entry>();

    // create a new instance for the entry in the journal
    public void EntryDisplay(){
        foreach(Entry entry in Entries){
            entry.DisplayText();
        }
    }

     public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine($"{entry._text}");
            }
        }
        Console.WriteLine($"Entries saved to {fileName}");
    }

    // reading text from file
    public void ReadFromFile(){
        foreach (string line in lines){
            string [] parts = line.Split(" ");
            if (parts.Length >= 2)  // Check if there is a second part
            {
                string text = parts[1];
                Console.WriteLine(text);
            }
        }
    }


}
