using System;

class Program
{
    static void Main()
    {
        // Core Requirements
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess;
        int attempts = 0;

        Console.WriteLine("Welcome to Guess My Number!");

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != magicNumber);

        // Stretch Challenge
        Console.WriteLine($"It took you {attempts} attempts to guess the magic number.");

        // Ask if the user wants to play again
        Console.Write("Do you want to play again? (yes/no): ");
        string playAgain = Console.ReadLine();

        // Loop back and play the game again if the user says "yes"
        while (playAgain.ToLower() == "yes")
        {
            magicNumber = random.Next(1, 101);
            attempts = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            } while (guess != magicNumber);

            // Stretch Challenge
            Console.WriteLine($"It took you {attempts} attempts to guess the magic number.");
            
            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
    }
}
