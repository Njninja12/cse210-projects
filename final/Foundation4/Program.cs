using System;

class Program
{
    static void Main()
    {
        // Create activities
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 30, 6.0),
            new Swimming("03 Nov 2022", 30, 10)
        };

        // Display results
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}