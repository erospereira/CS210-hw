// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create job instances
        Job job1 = new Job("Software Engineer", "Microsoft", "2019", "2022");
        Job job2 = new Job("Manager", "Apple", "2022", "2023");

        // Display companies using dot notation
        Console.WriteLine(job1._company); // Microsoft
        Console.WriteLine(job2._company); // Apple

        // Display job details using the Display method
        job1.Display();
        job2.Display();

        // Create a resume instance
        Resume myResume = new Resume("Allison Rose");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display resume details using the Display method
        myResume.Display();
    }
}
