using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address eventAddress = new Address("123 Main St", "Anytown", "CA", "USA");

        // Create events
        Event genericEvent = new Event("Generic Event", "Description of a generic event", "2023-01-01", "12:00 PM", eventAddress);
        Lecture lectureEvent = new Lecture("Tech Talk", "Learn about the latest technology", "2023-02-15", "2:00 PM", eventAddress, "John Doe", 50);
        Reception receptionEvent = new Reception("Networking Mixer", "Socialize and network with professionals", "2023-03-20", "6:00 PM", eventAddress, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer BBQ", "Enjoy outdoor activities and good food", "2023-07-10", "4:00 PM", eventAddress, "Sunny with a chance of rain");

        // Display results
        Console.WriteLine("Generic Event Standard Details:\n" + genericEvent.GetStandardDetails());
        Console.WriteLine("\nGeneric Event Full Details:\n" + genericEvent.GetFullDetails());
        Console.WriteLine("\nGeneric Event Short Description:\n" + genericEvent.GetShortDescription());

        Console.WriteLine("\n-----------------------------------------\n");

        Console.WriteLine("Lecture Event Standard Details:\n" + lectureEvent.GetStandardDetails());
        Console.WriteLine("\nLecture Event Full Details:\n" + lectureEvent.GetFullDetails());
        Console.WriteLine("\nLecture Event Short Description:\n" + lectureEvent.GetShortDescription());

        Console.WriteLine("\n-----------------------------------------\n");

        Console.WriteLine("Reception Event Standard Details:\n" + receptionEvent.GetStandardDetails());
        Console.WriteLine("\nReception Event Full Details:\n" + receptionEvent.GetFullDetails());
        Console.WriteLine("\nReception Event Short Description:\n" + receptionEvent.GetShortDescription());

        Console.WriteLine("\n-----------------------------------------\n");

        Console.WriteLine("Outdoor Event Standard Details:\n" + outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nOutdoor Event Full Details:\n" + outdoorEvent.GetFullDetails());
        Console.WriteLine("\nOutdoor Event Short Description:\n" + outdoorEvent.GetShortDescription());
    }
}