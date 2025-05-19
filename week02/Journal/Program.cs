using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Please select one of the folowing choices:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save entries to file");
        Console.WriteLine("4. Load entries from file");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        string optionInput = Console.ReadLine();


        if (optionInput == "1")
        {
            PromptGenerator promptGenerator = new PromptGenerator();
            string randomPrompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine($"Prompt: {randomPrompt}");
        }

        else if (optionInput == "2")
        {
            Console.WriteLine("Displaying all entries...");
            // 
        }

        else if (optionInput == "3")
        {
            Console.WriteLine("Saving entries to file...");
            // 
        }

        else if (optionInput == "4")
        {
            Console.WriteLine("Loading entries from file...");
            // 
        }

        else if (optionInput == "5")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
}