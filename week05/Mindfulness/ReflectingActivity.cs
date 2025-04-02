public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description) 
    {
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you served someone close to you.");
        _prompts.Add("Think of a time when you surprised yourself.");

        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you have done even better?");
        _questions.Add("What did you do really well during this experience?");
        _questions.Add("What did you learn as a result of this experience?");
    }

    public void Run()
    {
        DisplayPrompt();
        DisplayQuestions();
    }

    string GetRandomPrompt()
    {
        Random rnd = new Random();
        int rndNum = rnd.Next(_prompts.Count);
        return _prompts[rndNum];
    }

    string GetRandomQuestion()
    {
        if (_questions.Count > 0)
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(_questions.Count);
            string rndStr = _questions[rndNum];
            _questions.Remove(_questions[rndNum]);
            return rndStr;
        }
        else
        {
            return "You have run out of prompts!";
        }
    }

    void DisplayPrompt()
    {
        Console.WriteLine($"\nConsider the following prompt:\n --- {GetRandomPrompt()} ---");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }

    void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine();

        while (currentTime < futureTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            base.ShowSpinner(1);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}