using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program");
        Console.WriteLine("Press enter to start, or type 'quit' to exit.");
        var userInput = Console.ReadLine();
        if (userInput.ToLower() == "quit")
        {
            return;
        }

        var reference = new ScriptureReference("John 3:16");
        var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        MemorizationSession(scripture);
    }

    static void MemorizationSession(Scripture scripture)
    {
        var text = scripture.Text;
        var hiddenWords = new List<ScriptureWord>();

        while (hiddenWords.Count < scripture.Words.Length)
        {
            Console.Clear();
            Console.WriteLine($"Scripture Reference: {scripture.Reference.Reference}");
            Console.WriteLine();
            Console.WriteLine("Scripture Text:");

            string[] visibleWords = scripture.HideWords(hiddenWords);
            Console.WriteLine(string.Join(" ", visibleWords));

            Console.WriteLine();
            Console.WriteLine("Press enter to continue, or type 'quit' to exit.");
            
            var userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                return;
            }

            hiddenWords.Add(scripture.GetRandomUnhiddenWord(hiddenWords));
        }

        Console.Clear();
        Console.WriteLine("You've successfully memorized the entire scripture!");
    }
}


