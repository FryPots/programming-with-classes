using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>()
        {
            new RunningActivity(30, 5.0f),
            new RunningActivity(45, 8.5f),
            new RunningActivity(20, 3.2f), 

            new CyclismActivity(60, 20.0f),
            new CyclismActivity(30, 15.5f),
            new CyclismActivity(90, 25.0f),

            new SwimmingActivity(30, 20),
            new SwimmingActivity(45, 30),
            new SwimmingActivity(25, 15)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}