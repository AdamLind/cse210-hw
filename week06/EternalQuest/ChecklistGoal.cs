public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points) 
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points) 
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    
    public override int RecordEvent()
    {
        int points = int.Parse(_points);
        _amountCompleted++;
        if (IsComplete())
        {
            points+=_bonus;
        }
        return points;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    
    public override string GetDetailsString()
    {
        string isComplete = " ";
        if (IsComplete())
        {
            isComplete = "X";    
        }
        return $"[{isComplete}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation() {
        return $"ChecklistGoal:{_shortName}~{_description}~{_points}~{_bonus}~{_target}~{_amountCompleted}";
    }   
}