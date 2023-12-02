using System;

public class Activity
{
    private string date;
    public int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        this.date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        return $"{date} {GetType().Name} ({_lengthInMinutes} min) - {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}