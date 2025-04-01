using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        MathAssignment math = new MathAssignment("Adam", "Fractions", "3.5", "2-50");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());   
             
        WritingAssignment writing = new WritingAssignment("Adam Lind", "World History", "How The USA Became A World Power");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}