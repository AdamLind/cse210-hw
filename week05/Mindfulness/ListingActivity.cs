public class ListingActivity : Activity
{
    int _count = 0;
    List<string> _prompts = new List<string>();
    List<string> _responses = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("What are you grateful for right now?");
        _prompts.Add("In what ways have you seen yourself improve this month?");
    }

    public void Run()
    {
        Random rnd = new Random();
        int rndNum = rnd.Next(_prompts.Count);

        Console.WriteLine($"\nList as many responses as you can to the following prompt:\n --- {_prompts[rndNum]} ---");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        string dateText = startTime.ToShortDateString();

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string listItem = Console.ReadLine();
            _responses.Add(listItem);
            _count++;
            currentTime = DateTime.Now;
        }

        using (StreamWriter outputFile = new StreamWriter("listingActivity.txt", append: true))
        {
            outputFile.Write($"{dateText}~");
            outputFile.Write($"{_prompts[rndNum]}");
            foreach (string response in _responses)
            {
                outputFile.Write($"~{response}");
            }
            outputFile.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine($"Your listed items can be found on the main menu.");

    }

}