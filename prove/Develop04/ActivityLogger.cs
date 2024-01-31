using System;

public static class ActivityLogger
{
    public static void LogBreathingActivity(int count)
    {
        Console.WriteLine($"Breathing activities performed: {count}");
    }

    public static void LogReflectionActivity(int count)
    {
        Console.WriteLine($"Reflection activities performed: {count}");
    }

    public static void LogListingActivity(int count)
    {
        Console.WriteLine($"Listing activities performed: {count}");
    }
}
