using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        DateTime theCurrentTime = DateTime.Now;
        int userAction = -1;
        var _entries = new List<Entry> {};
        string loadFileName = "";
        PromptGenerator promptGenerator = new PromptGenerator();

        string dateText = theCurrentTime.ToShortDateString();
        Console.Clear();
        Console.WriteLine("Before we get started, in a word, how are you feeling right now?");
        Console.Write("> ");
        string feeling = Console.ReadLine();
        Console.WriteLine("Thank you for answering.");
        
        while (userAction != 5)
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userAction = int.Parse(Console.ReadLine());

            if (userAction < 1 || userAction > 5)
            {
                Console.WriteLine("Please enter a number between 1 and 5");
            }
            else if (userAction == 1) 
            {
                if (promptGenerator._prompts.Count > 0)
                {
                    string rndPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(rndPrompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    
                    Entry entry = new Entry();
                    entry._date = dateText;
                    entry._prompt = rndPrompt;
                    entry._response = response;
                    entry._feeling = feeling;

                    _entries.Add(entry);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have used all your prompts for today!");
                }
            }
            else if (userAction == 2)
            {
                Console.Clear();
                foreach (Entry item in _entries)
                {
                    Console.WriteLine($"Date: {item._date} - Prompt: {item._prompt}");
                    Console.WriteLine($"Feeling at time of writing: {item._feeling}");
                    Console.WriteLine($"{item._response}\n");
                }
            }
            else if (userAction == 3)
            {
                Console.Clear();
                _entries.Clear();
                Console.WriteLine("What file would you like to load?");
                Console.Write("> ");
                loadFileName = Console.ReadLine();
                string[] lines = File.ReadAllLines(loadFileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("~");
                    
                    Entry loadedEntry = new Entry();
                    loadedEntry._date = parts[0];
                    loadedEntry._prompt = parts[1];
                    loadedEntry._response = parts[2];
                    loadedEntry._feeling = parts[3];
                    _entries.Add(loadedEntry);
                    Console.WriteLine($"Date: {loadedEntry._date} - Prompt: {loadedEntry._prompt}");
                    Console.WriteLine($"Feeling at time of writing: {loadedEntry._feeling}");
                    Console.WriteLine($"{loadedEntry._response}\n");
                }
            }
            else if (userAction == 4)
            {
                Console.Clear();
                string saveFileName;
                if (loadFileName == "")
                {
                    Console.WriteLine("What file would you like to save to?");
                    Console.Write("> ");
                    saveFileName = Console.ReadLine();
                }
                else
                {
                    saveFileName = loadFileName;
                }
                using (StreamWriter outputFile = new StreamWriter(saveFileName))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._response}~{entry._feeling}");
                    }
                }
            }
            else if (userAction == 5)
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}