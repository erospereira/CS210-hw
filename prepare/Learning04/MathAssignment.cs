// This is the MathAssignment.cs
public class MathAssignment : Assignment
{
    private int _problemsStart;
    private int _problemsEnd;

    public MathAssignment(string studentName, string topic, int problemsStart, int problemsEnd)
        : base(studentName, topic)
    {
        _problemsStart = problemsStart;
        _problemsEnd = problemsEnd;
    }

    public string GetHomeworkList()
    {
        return $"Section {_problemsStart}.{_problemsEnd} Problems {_problemsStart}-{_problemsEnd}";
    }
}
