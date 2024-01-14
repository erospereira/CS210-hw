using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Core Requirements
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Compute the sum of the numbers
        int sum = numbers.Sum();

        // Compute the average of the numbers
        double average = numbers.Average();

        // Find the maximum number in the list
        int maxNumber = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Stretch Challenge
        // Filter positive numbers
        List<int> positiveNumbers = numbers.Where(num => num > 0).ToList();

        // Find the smallest positive number
        int smallestPositive = positiveNumbers.Min();

        // Sort the list
        numbers.Sort();

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
