
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet!");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
            }
        }
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score); 
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }

        Console.WriteLine("Goals saved!");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isComplete)
                {
                    goal.RecordEvent(); 
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                int timesCompleted = int.Parse(parts[4]);
                int targetCount = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonus);
                for (int j = 0; j < timesCompleted; j++)
                {
                    goal.RecordEvent(); 
                }
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded!");
    }
}