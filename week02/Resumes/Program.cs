using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Cashier";
        job2._company = "McDonald's";
        job2._startYear = 2017;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Gilbertoisai Martinez";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}