using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // create a new instance name job1
        Job job1 = new Job();
        // set the properties of job1
        job1._jobTitle = "Software Developer";
        job1._companyName = "Microsoft";
        job1._startYear = "2023";
        job1._endYear = "2025";


        // create a new instance for the resume
        Resume resume1 = new Resume();

        // add the needed infomations
        resume1._memberName = "Nephi Nuley Stanley";
        resume1._job.Add(job1);

        resume1.ResumeDisplay();
    
    }

}