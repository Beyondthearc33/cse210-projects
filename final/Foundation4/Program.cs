using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(5.5, 120, "03 Nov 2022"));
        activities.Add(new Cycling(10, 30, "04 Sept 2023"));
        activities.Add(new Swimming(12, 15, "12 Oct 2025"));

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.getSummary());
        }
    }
}