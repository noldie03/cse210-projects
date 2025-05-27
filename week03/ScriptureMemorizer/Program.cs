using System;
using System.Collections.Generic;

// For Stretch challenge, I included a list of scriptures to choose from in which it will randomly select one to display.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart and lean not on your own understanding;"),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),

        };

        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture scripture = scriptureLibrary[index];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden! Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("Press Enter to hide 3 more words, or type 'exit' to quit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}