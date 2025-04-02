using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "-1";

        while (response != "6")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. View listing activity responses");
            Console.WriteLine(" 5. See time spent in activities");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            response = Console.ReadLine();

            if (response == "1")
            {
                BreathingActivity activity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
                activity.AddTimeToTotal(0);
            }
            else if (response == "2")
            {
                ReflectingActivity activity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
                activity.AddTimeToTotal(1);
            }
            else if (response == "3")
            {
                ListingActivity activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
                activity.AddTimeToTotal(2);
            }
            else if (response == "4")
            {
                Console.Clear();
                string[] lines = File.ReadAllLines("listingActivity.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split("~");

                    string date = parts[0];
                    string prompt = parts[1];
                    Console.WriteLine($"\nDate: {date}");
                    Console.WriteLine($"Prompt: {prompt}");
                    string[] answers = parts.Skip(2).ToArray();
                    Console.WriteLine("Answers:");
                    foreach(string answer in answers)
                    {
                        Console.WriteLine($"{answer}");
                    }
                }
                Console.Write("\nPress Enter To Return To Menu");
                Console.ReadLine();
            }
            else if (response == "5")
            {
                Console.Clear();
                string[] lines = File.ReadAllLines("timeTotals.txt");

                string[] parts = lines[0].Split("~");
                Console.WriteLine($"Breathing Activity: {parts[0]} (seconds)");
                Console.WriteLine($"Reflection Activity: {parts[1]} (seconds)");
                Console.WriteLine($"Listing Activity: {parts[2]} (seconds)");
                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
            }
        }
    }
}