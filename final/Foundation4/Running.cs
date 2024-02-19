using System;

public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (durationMinutes / 60.0); // miles per hour
    }

    public override double GetPace()
    {
        return durationMinutes / distance; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
