public class Activity
{
    string _name;
    string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        Console.Write("> ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell Done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds) 
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void AddTimeToTotal(int position)
    {
        string[] lines = File.ReadAllLines("timeTotals.txt");
        string line = lines[0];
        string[] parts = line.Split("~");
        List<int> timeInts = new List<int>();
        foreach (string part in parts)
        {
            Console.WriteLine(part);
            timeInts.Add(int.Parse(part));
        }
        timeInts[position] += _duration;

        using (StreamWriter outputFile = new StreamWriter("timeTotals.txt"))
        {
            outputFile.Write($"{timeInts[0]}~{timeInts[1]}~{timeInts[2]}");
        }

    }
}