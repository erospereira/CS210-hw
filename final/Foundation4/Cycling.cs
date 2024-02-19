using System;

public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (durationMinutes / 60.0); // miles
    }

    public override double GetPace()
    {
        return 60.0 / speed; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance: {GetDistance()} miles, Speed: {speed} mph, Pace: {GetPace()} min per mile";
    }
}
