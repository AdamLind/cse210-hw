using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        RunningActivity r = new RunningActivity(30, 3);
        CyclingActivity c = new CyclingActivity(30, 10);
        SwimmingActivity s = new SwimmingActivity(30, 30);
        activities.Add(r);
        activities.Add(c);
        activities.Add(s);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}