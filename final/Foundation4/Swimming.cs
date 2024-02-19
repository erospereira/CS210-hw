using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0 * 0.62; // Convert laps to miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / (durationMinutes / 60.0); // miles per hour
    }

    public override double GetPace()
    {
        return durationMinutes / GetDistance(); // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
