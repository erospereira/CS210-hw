using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address("123 Main St", "Anytown", "State", "12345");

        Lecture lecture = new Lecture("Lecture Title", "An interesting lecture", DateTime.Now.Date, new TimeSpan(14, 0, 0), eventAddress, "John Doe", 50);
        Reception reception = new Reception("Reception Title", "A delightful reception", DateTime.Now.Date.AddDays(7), new TimeSpan(18, 0, 0), eventAddress, "example@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Gathering Title", "A fun outdoor gathering", DateTime.Now.Date.AddDays(14), new TimeSpan(10, 0, 0), eventAddress, "Sunny skies");

        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
