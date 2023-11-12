using System;

// define the public class name for resume
public class Resume{
    // variabel for the member name
    public string _memberName;

    // creating a list data using job as datatype
    public List<Job>_job = new List<Job>();

    public void ResumeDisplay(){
        Console.WriteLine($"Name {_memberName}\n Jobs: ");

        foreach(Job j in _job){
            j.DisplayJob();
        }
    }
}