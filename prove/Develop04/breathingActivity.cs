using System;

// Breathing Activity
class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public override void RunActivity()
    {
        base.RunActivity();
        ShowMessage("Let's start deep breathing:");
        for (int i = 0; i < duration; i++)
        {
            ShowMessage("Breathe in...");
            DisplaySpinner();  // Show a spinner animation
            Thread.Sleep(1500);  // Pause for 1.5 seconds
            ShowMessage("Breathe out...");
            DisplaySpinner();  // Show a spinner animation
            Thread.Sleep(1500);  // Pause for 1.5 seconds
        }
    }
}
