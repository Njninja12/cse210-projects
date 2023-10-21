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

        var reference = new ScriptureReference("John 3:16-17");
        var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. For God did not send hise Son into the world to condemn the world, but to save the world through him.");
        MemorizationSession(scripture);
    }

    static void MemorizationSession(Scripture scripture)
    {
        var reference = scripture.Reference;
        var text = scripture.Text;
        var hiddenWords = new List<ScriptureWord>();

        while (hiddenWords.Count < scripture.Words.Length)
        {
            Console.Clear();
            Console.WriteLine($"Scripture Reference: {scripture.Reference.Reference}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue, or type 'quit' to exit.");
            Console.WriteLine();

            string[] visibleWords = scripture.HideWords(hiddenWords);
            Console.WriteLine(string.Join(" ", visibleWords));

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