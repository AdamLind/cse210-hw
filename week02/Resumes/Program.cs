using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Manager";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume resume1 = new Resume();
        resume1._name = "Adam Lind";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}