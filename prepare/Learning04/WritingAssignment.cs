// This is the WritingAssignment.cs
public class WritingAssignment : Assignment
{
    private string _writingPrompt;

    public WritingAssignment(string studentName, string topic, string writingPrompt)
        : base(studentName, topic)
    {
        _writingPrompt = writingPrompt;
    }

    public string GetWritingInformation()
    {
        // This is the access _studentName using the GetStudentName method
        return $"{GetStudentName()} - {_writingPrompt}";
    }
    
    // This is the public method to access the private _studentName variable
    
}
