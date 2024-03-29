using System;

class Program
{
    static void Main()
    {
        // It will test the constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // Display fractions using GetFractionString method
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction3.GetFractionString());

        // Ity will display decimal values using GetDecimalValue method
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetDecimalValue());

        // It will test getters and setters
        fraction1.SetTop(3);
        fraction1.SetBottom(4);

        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());

        // It will display the fraction using GetFractionString after modifying values
        Console.WriteLine(fraction1.GetFractionString());
    }
}
