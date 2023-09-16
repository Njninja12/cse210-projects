using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"You recieved a {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the course.");
        }
        else
        {
            Console.WriteLine("I'm sorry, you didn't pass. But don't give up, you can always try again.");
        }
    }
}