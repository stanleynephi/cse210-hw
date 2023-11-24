using System;
using System.Collections.Generic;
public class PromptGenerator{
    private List<string> _prompts;

    public PromptGenerator(){

        _prompts = new List<string>();
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Seeing the sun shine.");
        _prompts.Add("Speaking more kindly to my children.");
    }
    
    // Display all the elements in the list
    public string Text()
    {
        Random newRandom = new Random();
        int pop = newRandom.Next(_prompts.Count);
        return _prompts[pop];
    }




}