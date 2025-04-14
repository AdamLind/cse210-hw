public class CyclingActivity : Activity
{
    double _speed;

    public CyclingActivity(int duration, double speed) : base(duration)
    {
        _speed = speed;
        _type = "Cycling";
    }

    public override double GetDistance()
    {
        return _duration / 60 * _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}