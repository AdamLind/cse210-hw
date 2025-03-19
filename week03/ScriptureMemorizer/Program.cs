using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Proverbs", 3, 5, 6);
        Scripture s = new Scripture(r, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowlege Him, and He shall direct they paths.");
        string response = "";
        while (response != "quit")
        {
            Console.Clear();
            Console.WriteLine(s.GetDisplayText());
            Console.Write("\nPress enter to continue or type 'quit' to finish.\n> ");
            response = Console.ReadLine();
            if (s.IsCompletelyHidden() == true)
            {
                break;
            }

            s.HideRandomWords(3);
        }
    }
}