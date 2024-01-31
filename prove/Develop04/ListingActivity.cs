using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public new void PerformActivity()
    {
        StartActivity();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Count)];

        Console.WriteLine(prompt);
        Console.WriteLine("You can start listing now.");

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            // This is a simulation user listing items
            string listItem = Console.ReadLine();
            Console.WriteLine($"Item: {listItem}");

            // This will continue the activity logic here
            // ...

            // This simulate the activity
            Thread.Sleep(1000);
        }

        Console.WriteLine("Listing completed.");

        EndActivity();
        ActivityLogger.LogListingActivity(activityCounter);
    }
}
