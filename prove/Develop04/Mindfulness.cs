using System;

// Base class for all activities
class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public MindfulnessActivity(string name, string description, int duration)
    {
        this.name = name;
        this.description = description;
        this.duration = duration;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(2000);  // Pause for 2 seconds
    }

    public void DisplaySpinner()
    {
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
    }

    public virtual void RunActivity()
    {
        ShowMessage($"{name} - {description}");
        ShowMessage("Get ready to begin...");
        Thread.Sleep(1500);  // Pause for 1.5 seconds
    }
}