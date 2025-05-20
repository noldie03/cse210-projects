using System;

class Program
{
    static void Main(string[] args)
    {
        string optionInput = "";
        Journal journal = new Journal();

        while (optionInput != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("Hello World! This is the Journal Project.");
            Console.WriteLine("Please select one of the folowing choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            optionInput = Console.ReadLine();


            if (optionInput == "1")
            {
                journal.AddEntry();
            }

            else if (optionInput == "2")
            {
                journal.DisplayEntries();
            }

            else if (optionInput == "3")
            {
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (optionInput == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
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
}