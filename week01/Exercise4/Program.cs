using System;
using System.Collections.Generic;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0) {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0) {
                numbers.Add(number);
            }
        }
        int sum = 0;
        int lgnum = -1;
        foreach (int line in numbers) {
            sum += line;
            if (line > lgnum) {
                lgnum = line;
            }
        }
        float avg = ((float)sum)/numbers.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {lgnum}");
    }
}