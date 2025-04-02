public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {}

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("\n\nBreathe in... ");
            base.ShowCountDown(4);
            Console.Write("\nNow breathe out... ");
            base.ShowCountDown(6);
            currentTime = DateTime.Now;
        }

    }
}