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

        var _reference = new ScriptureReference("John 3:16");
        var _scripture = new Scripture(_reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        MemorizationSession(_scripture);
    }

    static void MemorizationSession(Scripture _scripture)
    {
        var _text = _scripture.Text;
        var _hiddenWords = new List<ScriptureWord>();

        while (_hiddenWords.Count < _scripture.Words.Length)
        {
            Console.Clear();
            Console.WriteLine($"Scripture Reference: {_scripture.Reference}");
            Console.WriteLine();
            Console.WriteLine("Scripture Text:");

            string[] _visibleWords = _scripture.HideWords(_hiddenWords);
            Console.WriteLine(string.Join(" ", _visibleWords));

            Console.WriteLine();
            Console.WriteLine("Press enter to continue, or type 'quit' to exit.");
            
            var userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                return;
            }

            _hiddenWords.Add(_scripture.GetRandomUnhiddenWord(_hiddenWords));
        }

        Console.Clear();
        Console.WriteLine("You've successfully memorized the entire scripture!");
    }
}

