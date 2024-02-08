using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        // No additional initialization needed
    }

    public override void RecordEvent()
    {
        // No specific recording event for eternal goal
    }

    public override bool IsComplete()
    {
        // Eternal goal is never complete
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points},0";
    }
}
