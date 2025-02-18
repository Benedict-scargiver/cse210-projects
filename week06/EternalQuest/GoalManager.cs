using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Sample goals
        _goals.Add(new SimpleGoal("Run a marathon", "Complete a marathon run", 1000));
        _goals.Add(new EternalGoal("Read scriptures", "Daily scripture reading", 100));
        _goals.Add(new ChecklistGoal("Attend temple", "Visit the temple 10 times", 50, 10, 500));

        // Sample events
        _goals[0].RecordEvent();  // Complete SimpleGoal
        _goals[1].RecordEvent();  // Record EternalGoal
        _goals[2].RecordEvent();  // Record ChecklistGoal
        _goals[2].RecordEvent();  // Record ChecklistGoal

        DisplayPlayerInfo();
        ListGoalDetails();

        // Save and Load goals
        SaveGoals();
        LoadGoals();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Points: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal() 
    {
        // Code to create new goals
    }

    public void RecordEvent()
    {
        // Code to record an event
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string goalData = reader.ReadLine();
                    Console.WriteLine(goalData);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
