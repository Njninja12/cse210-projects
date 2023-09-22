using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type zero when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        int avg = sum / numbers.Count;
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + avg);
        Console.WriteLine("The largest number is: " + largest);
    }
}