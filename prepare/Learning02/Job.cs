using System;

// creating a public class
public class Job{
    public string _companyName;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // display the results
    public void DisplayJob(){
        Console.WriteLine($"Job Title {_jobTitle}({_companyName})\nStart Year: {_startYear}\nEnd Year: {_endYear}");
        }
}