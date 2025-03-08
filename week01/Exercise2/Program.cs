using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        string letter = "";


        if (percentage >= 90) {
            letter = "A";
        }
        else if (percentage >= 80) {
            letter = "B";
        }
        else if (percentage >= 70) {
            letter = "C";
        }
        else if (percentage >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"\nYour letter grade is: {letter}");
        if (percentage >= 70) {
            Console.Write("Congrats on passing!");
        }
        else {
            Console.Write("Try harder next time!");
        }
    }
}