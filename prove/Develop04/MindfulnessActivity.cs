using System;
using System.Diagnostics;
using System.Threading;

public class MindfulnessActivity
{
    protected static int activityCounter = 0;

    protected string activityName;
    protected string description;
    protected int duration;

    public MindfulnessActivity(string name, string desc)
    {
        activityName = name;
        description = desc;
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void StartActivity()
    {
        activityCounter++;
        Console.WriteLine($"Starting {activityName} activity (Activity #{activityCounter})...");
        Console.WriteLine(description);
        Console.Write($"Enter duration in seconds for {activityName}: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine($"Get ready to begin {activityName} in 3 seconds...");
        Thread.Sleep(3000);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Great job! You have completed the {activityName} activity.");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Pausing for reflection...");
        Thread.Sleep(3000);
    }

    public void PerformActivity()
    {
        StartActivity();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            PerformActivityLogic();

            // This will simulate the activity
            Thread.Sleep(1000);
        }

        EndActivity();
    }

    protected virtual void PerformActivityLogic()
    {
        // This following method can be overridden by subclasses to define the specific activity logic.
        // For example, the BreathingActivity, ReflectionActivity, ListingActivity, etc.
    }
}
