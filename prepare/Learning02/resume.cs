// Resume.cs

using System.Collections.Generic;

public class Resume
{
    private string _personName;
    private List<Job> _jobs;

    // Constructor
    public Resume(string personName)
    {
        _personName = personName;
        _jobs = new List<Job>();
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");

        foreach (var job in _jobs)
        {
            job.Display();
        }
    }

    // AddJob method
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }
}
