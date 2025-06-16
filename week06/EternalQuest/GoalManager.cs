using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public int Score => _score;
    private string _lastTitle = "Novice";
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i] is ChecklistGoal checklist)
            {
                Console.WriteLine($"{i + 1}. {checklist.GetStatus()} {checklist.Name} - {checklist.Description} {checklist.GetProgress()}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].Name} - {_goals[i].Description}");
            }
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int points = _goals[goalIndex].RecordEvent();
            _score += points;
            Console.WriteLine(points > 0
                ? $"Event recorded! You earned {points} points."
                : "This goal is already complete.");

            // Title check
            string newTitle = GetTitle(_score);
            if (newTitle != _lastTitle)
            {
                Console.WriteLine($"Congratulations! You have earned the title: {newTitle}!");
                _lastTitle = newTitle;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
                writer.WriteLine(goal.Serialize());
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            if (parts[0] == "SimpleGoal")
            {
                var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4])) sg.RecordEvent();
                _goals.Add(sg);
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                var cg = new ChecklistGoal(
                    parts[1], // name
                    parts[2], // description
                    int.Parse(parts[3]), // points
                    int.Parse(parts[4]), // target count
                    int.Parse(parts[6])  // bonus
                );
                for (int j = 0; j < int.Parse(parts[5]); j++) cg.RecordEvent();
                _goals.Add(cg);
            }
        }
    }
    
    // For strech challenge
    private string GetTitle(int score)
    {
        if (score >= 5000) return "Legendary Achiever";
        if (score >= 2000) return "Master";
        if (score >= 1000) return "Expert";
        if (score >= 500) return "Apprentice";
        if (score >= 100) return "Beginner";
        return "Novice";
    }


}