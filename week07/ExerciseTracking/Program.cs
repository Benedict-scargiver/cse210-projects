using System;
using System.Collections.Generic;
using Activities;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2025, 2, 15), 60, 20.0),
            new CyclingActivity(new DateTime(2025, 2, 16), 90, 40.0),
            new SwimmingActivity(new DateTime(2025, 2, 17), 50, 80)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
