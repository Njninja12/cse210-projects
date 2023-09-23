using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string username = PromptUserName();
        int user_num = PromptUserNumber();
        int squared_num = SquareNumber(user_num);
        DisplayResults(username, squared_num);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int square)
    {
        int squared = square * square;
        return squared;
    }
    static void DisplayResults(string username, int squared)
    {
        Console.WriteLine($"Your name is {username} and the squared number is {squared}");
    }
}