using System;

class Program
{
    static void Main()
    {
        // Core Requirements
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        // Check if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Better luck next time. Keep working hard!");
        }

        // Stretch Challenge
        int lastDigit = gradePercentage % 10;
        string sign = "";

        // Determine the sign for grades A, B, and C
        if (letter == "A" || letter == "B" || letter == "C")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle exceptional cases for A+ and F grades
        if (letter == "A" && lastDigit >= 7)
        {
            letter = "A-";
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        // Display the final grade with sign
        Console.WriteLine($"Your final grade is: {letter}{sign}");
    }
}
