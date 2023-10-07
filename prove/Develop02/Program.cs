List<JournalEntry> journalEntries = new List<JournalEntry>();
Random random = new Random();
string choice = "";

while (choice != "5")
{
    Console.WriteLine("Please select one of the following: ");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // Generate a random prompt.
            string[] prompts = {
                        "If I had one thing I could do over today, what would it be?",
                        "What are you grateful for today?",
                        "Describe a challenge you faced today.",
                        "Write about a happy memory.",
                        "How did I see the hand of the Lord in my life today?",
                        // Add more prompts as needed.
                    };
            int index = random.Next(prompts.Length);
            string prompt = prompts[index];
            Console.WriteLine($"Prompt: {prompt}");

            // Get the journal entry from the user.
            Console.Write("Enter your journal entry: ");
            string entry = Console.ReadLine().Trim();

            // Get the current date and time.
            DateTime date = DateTime.Now;

            // Create a JournalEntry object and add it to the list.
            JournalEntry journalEntry = new JournalEntry(prompt, entry, date);
            journalEntries.Add(journalEntry);

            Console.WriteLine("Entry saved.");
            Console.WriteLine();
            break;

        case "2":
            // Display all saved journal entries.
            Console.WriteLine("Journal Entries:");
            foreach (JournalEntry Entry in journalEntries)
            {
                Console.WriteLine(Entry.ToString());
            }
            break;

        case "3":
            // Load journal entries from a specified file.
            Console.Write("Enter the name of the file to load: ");
            string loadFileName = Console.ReadLine().Trim();
            LoadEntries(journalEntries, loadFileName);
            Console.WriteLine("Entries loaded.");
            break;

        case "4":
            // Save journal entries to a specified file.
            Console.Write("Enter the name of the file to save: ");
            string saveFileName = Console.ReadLine().Trim();
            SaveEntries(journalEntries, saveFileName);
            Console.WriteLine("Entries saved.");
            break;

        case "5":
            // Exit the program.
            Console.WriteLine("Exiting Journal Application.");
            break;

        default:
            Console.WriteLine("Invalid option. Please select a valid option (1/2/3/4/5).");
            break;
    }
}

// Load journal entries from a file.
void LoadEntries(List<JournalEntry> journalEntries, string fileName)
{
    if (File.Exists(fileName))
    {
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string prompt = parts[0].Trim();
                string entry = parts[1].Trim();
                DateTime date = DateTime.Parse(parts[2].Trim());
                JournalEntry journalEntry = new JournalEntry(prompt, entry, date);
                journalEntries.Add(journalEntry);
            }
        }
    }
    else
    {
        Console.WriteLine($"File '{fileName}' not found.");
    }
}

// Save journal entries to a file.
void SaveEntries(List<JournalEntry> journalEntries, string fileName)
{
    using (StreamWriter writer = new StreamWriter(fileName))
    {
        foreach (var entry in journalEntries)
        {
            writer.WriteLine($"{entry.Prompt} | {entry.Entry} | {entry.Date}");
        }
    }
}

// Create a class to represent a journal entry.
class JournalEntry
{
    public string Prompt { get; }
    public string Entry { get; }
    public DateTime Date { get; }

    public JournalEntry(string prompt, string entry, DateTime date)
    {
        Prompt = prompt;
        Entry = entry;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nEntry: {Entry}\n";
    }
}