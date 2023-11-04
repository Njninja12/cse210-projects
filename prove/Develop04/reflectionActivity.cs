using System;

// Reflection Activity
class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity(string name, string description, int duration)
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

            string[] questions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            foreach (var question in questions)
            {
                ShowMessage(question);
                DisplaySpinner();  // Show a spinner animation
                Thread.Sleep(1500);  // Pause for 1.5 seconds
            }
        }
    }
}