using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    private void Pause()
    {
        Console.WriteLine("Press Enter to continue to the next question.");
        Console.ReadLine(); // This will wait for the user to press Enter
    }

    public new void PerformActivity()
    {
        base.PerformActivity(); // This will call the base class method

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);

        foreach (var question in reflectionQuestions)
        {
            Console.WriteLine(question);
            Pause();
        }

        Console.WriteLine("Pausing for next prompt...");
        Thread.Sleep(3000);

        stopwatch.Stop();
        ActivityLogger.LogReflectionActivity(activityCounter);
    }
}
