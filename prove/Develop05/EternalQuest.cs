class EternalQuestProgram
{
    private List<Goal> goals = new List<Goal>();
    private int userScore = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Choose the goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.Write("Enter the goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the goal value: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                switch (choice)
                {
                    case 1:
                        goals.Add(new SimpleGoal(name, value));
                        break;
                    case 2:
                        goals.Add(new EternalGoal(name, value));
                        break;
                    case 3:
                        Console.Write("Enter the target count for the checklist: ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            goals.Add(new ChecklistGoal(name, value, targetCount));
                        }
                        else
                        {
                            Console.WriteLine("Invalid target count. Checklist goal creation failed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Goal creation failed.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid goal value. Goal creation failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Goal creation failed.");
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter the goal name for recording an event: ");
        string goalName = Console.ReadLine();
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            userScore += goal.Value;
            Console.WriteLine($"Event recorded for {goalName}. You earned {goal.Value} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.GetGoalStatus()} {goal.Name} - Score: {goal.Value}");
        }

        Console.WriteLine($"\nTotal Score: {userScore}");
    }
}