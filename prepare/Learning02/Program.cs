using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Staff Engineer";
        job1._startYear = 2004;
        job1._endYear = 2012;

        // job1.Display();
        
        Job job2 = new Job();
        job2._company = "Nike";
        job2._jobTitle = "Director";
        job2._startYear = 2012;
        job2._endYear = 2023;

        // job2.Display();


        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "Luke";

        myResume.Display();

    //   Console.WriteLine(myResume._jobs[0]._jobTitle);

        
    }
}