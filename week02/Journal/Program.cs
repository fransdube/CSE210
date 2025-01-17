using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Set the working directory to the project folder
        Directory.SetCurrentDirectory("/CSE210/week02/Journal");

        Journal journal = new Journal();
        List<string> prompts = LoadPrompts("prompts.txt");

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
 
            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, prompts);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, List<string> prompts)
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        journal.AddEntry(new Entry(prompt, response, date));
        Console.WriteLine("Entry added successfully!");
    }

    static List<string> LoadPrompts(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Error: File '{filename}' not found.");
            return new List<string>();
        }

        List<string> prompts = new List<string>();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                prompts.Add(line);
            }
        }
        return prompts;
    }
}