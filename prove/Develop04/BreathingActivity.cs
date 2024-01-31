using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
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

    public void PerformActivity()
    {
        StartActivity();

        for (int i = 0; i < duration; i += 12) // Counting both inhale and exhale in one iteration
        {
            Console.WriteLine("Breathe in...");
            Countdown(6);

            Console.WriteLine("Breathe out...");
            Countdown(6);
        }

        EndActivity();
        ActivityLogger.LogBreathingActivity(activityCounter);
    }
}
