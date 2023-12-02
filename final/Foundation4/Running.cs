using System;

public class Running : Activity
{
    private double distance;

    public Running(string date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / _lengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / distance;
    }
}