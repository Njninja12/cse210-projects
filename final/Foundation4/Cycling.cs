public class Cycling : Activity
{
    private double speed;

    public Cycling(string date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}