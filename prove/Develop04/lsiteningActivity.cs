using System;

// Listing Activity
class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public override void RunActivity()
    {
        base.RunActivity();
        for (int i = 0; i < duration; i++)
        {
            ShowMessage(prompts[i % prompts.Length]);
            DisplaySpinner();  // Show a spinner animation
            Thread.Sleep(1500);  // Pause for 1.5 seconds
            ShowMessage("Start listing items:");

            List<string> items = new List<string>();
            while (true)
            {
                string item = Console.ReadLine();
                if (item.ToLower() == "done")
                    break;
                items.Add(item);
            }
            ShowMessage($"You listed {items.Count} items.");
            Thread.Sleep(1500);  // Pause for 1.5 seconds
        }
    }
}