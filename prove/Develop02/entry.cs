using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

// declare and entry class
public class Entry{

    // an instance for the list variables
    public Entry _prompt;

    public string _text;

    public string _date;


    public void DisplayText(){
        Console.WriteLine($"{_prompt}\n Date {_date}...{_text}");
    }

}

    

