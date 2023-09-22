using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 101);
        

        int guess_num = -1;

        while (magic_num != guess_num)
        {
            Console.WriteLine("What is your guess? ");
            guess_num = int.Parse(Console.ReadLine());

            if (guess_num > magic_num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess_num < magic_num)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("You guessed right!");
            }
        }
    }
}