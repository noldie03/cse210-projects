using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {

        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("> ");
        string entryText = Console.ReadLine();

        // Add entry to a list or file
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("yyyy-MM-dd");
        entry._promptText = randomPrompt;
        entry._entryText = entryText;
        _entries.Add(entry);
        Console.WriteLine("Entry added successfully!");

    }

    public void DisplayEntries()
    {
        // Check if there are entries that exists for STRETCH CHALLENGE
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("Displaying all entries...");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Entries saved to file successfully!");

    }

    public void LoadFromFile(string filename)
    {   
        // Check if the file exists for STRETCH CHALLENGE
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear(); // Clear current entries before loading new ones

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Entries loaded from file successfully!");
    }
}