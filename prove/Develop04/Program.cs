using System;

using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity (1-4): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                BreathingActivity activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration);
                activity.RunActivity();
            }
            else if (choice == "2")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                ReflectionActivity activity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", duration);
                activity.RunActivity();
            }
            else if (choice == "3")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                ListingActivity activity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);
                activity.RunActivity();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
            }
        }
    }
}
