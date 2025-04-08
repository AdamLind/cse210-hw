public class SimpleGoal : Goal
{
    bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return int.Parse(_points);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation() {
        return $"SimpleGoal:{_shortName}~{_description}~{_points}~{IsComplete()}";
    }   
}