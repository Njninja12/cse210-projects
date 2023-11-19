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
        Goal goal = goals.Find(g => g._name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            userScore += goal._value;
            Console.WriteLine($"Event recorded for {goalName}. You earned {goal._value} points.");
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
            Console.WriteLine($"{goal.GetGoalStatus()} {goal._name} - Score: {goal._value}");
        }

        Console.WriteLine($"\nTotal Score: {userScore}");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal._name}|{goal._value}|{goal._isCompleted}");
            }
        }

        using (StreamWriter writer = new StreamWriter("score.txt"))
        {
            writer.WriteLine(userScore);
        }

        Console.WriteLine("Goals and score saved successfully.");
    }

    public void LoadGoals()
    {
        goals.Clear(); // Clear existing goals before loading

        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string goalType = parts[0];
                    string name = parts[1];
                    int value = int.Parse(parts[2]);
                    bool isCompleted = bool.Parse(parts[3]);

                    switch (goalType)
                    {
                        case nameof(SimpleGoal):
                            goals.Add(new SimpleGoal(name, value) { _isCompleted = isCompleted });
                            break;
                        case nameof(EternalGoal):
                            goals.Add(new EternalGoal(name, value) { _isCompleted = isCompleted });
                            break;
                        case nameof(ChecklistGoal):
                            int targetCount = int.Parse(parts[4]);
                            goals.Add(new ChecklistGoal(name, value, targetCount) { _isCompleted = isCompleted });
                            break;
                        default:
                            Console.WriteLine($"Unknown goal type: {goalType}. Skipping.");
                            break;
                    }
                }
            }

            using (StreamReader reader = new StreamReader("score.txt"))
            {
                userScore = int.Parse(reader.ReadLine());
            }

            Console.WriteLine("Goals and score loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved data found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data: {ex.Message}");
        }
    }
}
