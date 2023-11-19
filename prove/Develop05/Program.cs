class Program
{
    static void Main()
    {
        EternalQuestProgram eternalQuestProgram = new EternalQuestProgram();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Program Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        eternalQuestProgram.CreateGoal();
                        break;
                    case 2:
                        eternalQuestProgram.RecordEvent();
                        break;
                    case 3:
                        eternalQuestProgram.DisplayGoals();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}