using System;

//create a class to ask the user to choose what scripture to memorise
public class Questions{
    // create a private variables for the questions
    private List<string>_questions;

    public Questions(){
        _questions = new List<string>();
        _questions.Add("What scripture do you want to memorize");

    }

    public string Choice(){
        return _questions[0];
    }
}