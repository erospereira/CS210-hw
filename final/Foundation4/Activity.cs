using System;

public class Activity
{
    protected DateTime date;
    protected int durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base class does not have a distance, overridden in derived classes
    }

    public virtual double GetSpeed()
    {
        return 0; // Base class does not have a speed, overridden in derived classes
    }

    public virtual double GetPace()
    {
        return 0; // Base class does not have a pace, overridden in derived classes
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} ({durationMinutes} min)";
    }
}
