public class SwimmingActivity : Activity
{
    double _laps;

    public SwimmingActivity(int duration, int laps) : base(duration)
    {
        _laps = laps;
        _type = "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _duration * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}