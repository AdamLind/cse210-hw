using System.IO;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    int _score;
    int _level;
    string _filename = "";

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine($"You are level {GetPlayerInfo()[0]} with {_score} total Exp.\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Player Info");
        Console.WriteLine(" 7. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    int[] GetPlayerInfo()
    {
        double reqExp = 100;
        double exp = _score;
        int level = 0;
        for (int i = 0; (exp - reqExp) > 0; i++)
        {
            exp-=reqExp;
            reqExp*=1.1;
            level++;
        }
        return [level, Convert.ToInt32(exp), Convert.ToInt32(reqExp)];
    }

    public void DisplayPlayerInfo()
    {
        int goalsCompleted = 0;
        foreach (Goal g in _goals)
        {
            if (g.IsComplete())
            {
                goalsCompleted++;
            }
        }
        int[] levelInfo = GetPlayerInfo();

        Console.WriteLine($"Total number of goals added: {_goals.Count}");
        Console.WriteLine($"Number of goals completed: {goalsCompleted}");
        Console.WriteLine($"Remaining: {_goals.Count - goalsCompleted}");
        Console.WriteLine($"Current level: {levelInfo[0]}");
        Console.WriteLine($"Current exp: {levelInfo[1]}/{levelInfo[2]} until level up");
        Console.WriteLine($"Exp required for next level: {levelInfo[2] - levelInfo[1]}");
        Console.WriteLine();

    }

    public void ListGoalNames()
    {
        int counter = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{counter}. {g.GetName()}");
            counter++;
        }
    }

    public void ListGoalDetails()
    {
        int counter = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{counter}. {g.GetDetailsString()}");
            counter++;
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string response = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        
        if (response == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (response == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (response == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int response = int.Parse(Console.ReadLine());
        if (_goals[response-1].IsComplete())
        {
            Console.Clear();
            Console.WriteLine("You've already finished this goal!\n");
        }
        else
        {
            int points = _goals[response-1].RecordEvent();
            _score += points;
            int level = GetPlayerInfo()[0];
            Console.WriteLine($"\nCongratulations! You have earned {points} exp!\n");
            if (level > _level)
            {
                Console.WriteLine("!!~~~ AMAZING! You've leveled up! ~~~!!\n");
                _level = level;
            }
        }
    }

    public void SaveGoals()
    {
        if (_filename == "")
        {
            Console.Write("What file would you like to save to? ");
            _filename = Console.ReadLine();
        }

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What file would you like to load from? ");
        _filename = Console.ReadLine();

        _goals.Clear();

        string[] content = System.IO.File.ReadAllLines(_filename);

        _score = int.Parse(content[0]);

        string[] lines = content.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] type = line.Split(":");
            string details = type[1];
            string[] parts = details.Split("~");

            if (type[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[0], parts[1], parts[2], bool.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (type[0] == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[0], parts[1], parts[2]);
                _goals.Add(goal);
            }
            else if (type[0] == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[4]), int.Parse(parts[3]), int.Parse(parts[5]));
                _goals.Add(goal);
            }
        }

        _level = GetPlayerInfo()[0];
    }
}