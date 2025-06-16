//For strech challenge, I added a feature that give a title that changes as the player earns more points.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine($"\nYour total points: {goalManager.Score}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("The types of goal are:\n1) Simple \n2) Eternal \n3) Checklist");
                Console.Write("The type of goal would you like to create? ");
                string type = Console.ReadLine();
                Console.Write("Whats the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string desc = Console.ReadLine();
                Console.Write("How many points for this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    goalManager.AddGoal(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    goalManager.AddGoal(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }

            else if (choice == "2")
            {
                goalManager.ListGoals();
            }
            else if (choice == "3")
            {
                goalManager.ListGoals();
                Console.Write("Which goal did you accomplish? (number): ");
                int idx = int.Parse(Console.ReadLine()) - 1;
                goalManager.RecordEvent(idx);
            }
            else if (choice == "4")
            {
                Console.Write("Filename to save: ");
                string file = Console.ReadLine();
                goalManager.Save(file);
            }
            else if (choice == "5")
            {
                Console.Write("Filename to load: ");
                string file = Console.ReadLine();
                goalManager.Load(file);
            }
            else if (choice == "6")
            {
                break;
            }


        }
    }
}