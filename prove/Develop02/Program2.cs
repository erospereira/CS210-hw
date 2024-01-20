using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        JournalManager journalManager = new JournalManager();

        while (true)
        {
            Console.WriteLine("\nJournal App Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journalManager.WriteNewEntry();
                    break;
                case "2":
                    journalManager.DisplayJournal();
                    break;
                case "3":
                    journalManager.SaveJournalToFile();
                    break;
                case "4":
                    journalManager.LoadJournalFromFile();
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}

class JournalManager
{
    private List<JournalEntry> journalEntries = new List<JournalEntry>();
    private Random random = new Random();
    private string journalFilePath = "journal.txt";

    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void WriteNewEntry()
    {
        string randomPrompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {randomPrompt}");

        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        JournalEntry entry = new JournalEntry(randomPrompt, response, currentDate);

        journalEntries.Add(entry);
        Console.WriteLine("Entry saved successfully!");
    }

    public void DisplayJournal()
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("Journal is empty. Write some entries first.");
            return;
        }

        foreach (var entry in journalEntries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journalEntries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved to file successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal from: ");
        string fileName = Console.ReadLine();

        try
        {
            List<JournalEntry> loadedEntries = new List<JournalEntry>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        JournalEntry entry = new JournalEntry(parts[1], parts[2], parts[0]);
                        loadedEntries.Add(entry);
                    }
                }
            }

            journalEntries = loadedEntries;
            Console.WriteLine("Journal loaded from file successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }
}
