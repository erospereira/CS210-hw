using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string reference;
    private string text;
    private HashSet<int> hiddenWords = new HashSet<int>();
    private int revealedWordsCount = 0;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
    }

    public string HideRandomWords()
    {
        string[] words = text.Split();
        int[] hiddenWordIndices = GetRandomIndices(Math.Min(3, words.Length));

        foreach (int index in hiddenWordIndices)
        {
            hiddenWords.Add(index);
        }

        string hiddenText = string.Join(" ", words.Select((word, index) => hiddenWords.Contains(index) ? "_____" : word));
        return $"{reference}: {hiddenText}";
    }

    public string RevealNextWord()
    {
        string[] words = text.Split();

        if (revealedWordsCount < words.Length)
        {
            string revealedText = string.Join(" ", words.Take(revealedWordsCount + 1));
            revealedWordsCount++;
            return $"{reference}: {revealedText}";
        }
        else
        {
            return $"{reference}: All words are already revealed.";
        }
    }

    public bool AllWordsHidden()
    {
        return hiddenWords.Count == text.Split().Length;
    }

    public bool AllWordsRevealed()
    {
        return revealedWordsCount == text.Split().Length;
    }

    private int[] GetRandomIndices(int count)
    {
        Random random = new Random();
        List<int> indices = new List<int>();

        while (indices.Count < count)
        {
            int index = random.Next(text.Split().Length);
            if (!indices.Contains(index))
            {
                indices.Add(index);
            }
        }

        return indices.ToArray();
    }
}

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Hide random words");
            Console.WriteLine("2. Reveal next word");
            Console.WriteLine("3. Quit");
            Console.Write("Enter your choice: ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    HideRandomWords(scripture);
                    break;
                case "2":
                    RevealNextWord(scripture);
                    break;
                case "3":
                    Console.WriteLine("Program ended.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void HideRandomWords(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.HideRandomWords());
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }

    static void RevealNextWord(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.RevealNextWord());
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }
}
