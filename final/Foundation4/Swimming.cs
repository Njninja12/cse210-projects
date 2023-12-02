public class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000; // Convert to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / _lengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }
}