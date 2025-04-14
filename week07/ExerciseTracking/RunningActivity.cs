public class RunningActivity : Activity
{
    double _distance;

    public RunningActivity(int duration, double distance) : base(duration)
    {
        _distance = distance;
        _type = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _duration * 60;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }
}