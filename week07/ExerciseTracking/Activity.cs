public abstract class Activity
{
    string _date;
    protected double _duration;
    protected string _type;


    protected Activity(int time)
    {
        _date = DateTime.Today.ToShortDateString();
        _duration = time;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_type} ({_duration} min) - Distance {Math.Round(GetDistance(), 2, MidpointRounding.AwayFromZero)} miles, Speed {Math.Round(GetSpeed(), 2, MidpointRounding.AwayFromZero)} mph, Pace: {Math.Round(GetPace(), 2, MidpointRounding.AwayFromZero)} min per mile";
    }
    
}