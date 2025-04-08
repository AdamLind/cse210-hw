using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager manager = new GoalManager();
        string response = "-1";
        while (response != "7")
        {
            manager.Start();
            response = Console.ReadLine();
            Console.Clear();

            if (response == "1")
            {
                manager.CreateGoal();
            }
            else if (response == "2")
            {
                manager.ListGoalDetails();
            }
            else if (response == "3")
            {
                manager.SaveGoals();   
            }
            else if (response == "4")
            {
                manager.LoadGoals();                
            }
            else if (response == "5")
            {
                manager.RecordEvent();                
            }
            else if (response == "6")
            {
                manager.DisplayPlayerInfo();
            }
        }
    }
}