using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        RunningActivity r = new RunningActivity(30, 3);
        CyclingActivity c = new CyclingActivity(30, 10);
        SwimmingActivity s = new SwimmingActivity(30, 30);
        Console.WriteLine(r.GetSummary());
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(s.GetSummary());
    }
}