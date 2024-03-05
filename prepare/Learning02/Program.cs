using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        //Job One
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2017;

        //Job Two
        Job job2 = new Job();
        job2._jobTitle = "iOS Mobile Developer";
        job2._company = "Apple";
        job2._startYear = 2017;
        job2._endYear = 2024;

        //New Resume
        Resume myResume = new Resume();
        myResume._name = "Billy Jo Bob";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

        Console.WriteLine();
    }
}