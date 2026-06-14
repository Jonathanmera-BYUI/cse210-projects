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
    Console.WriteLine("No goals created.");
    return;
}

    for (int i = 0; i < _goals.Count; i++)
{
    Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
}
}

    public void RecordEvent(int index)
{
    if (index >= 0 && index < _goals.Count)
{
    _goals[index].RecordEvent();

    _score += _goals[index].GetPoints();
    _score += _goals[index].GetBonus();
}
}

    public void DisplayScore()
{
    Console.WriteLine($"Score: {_score}");
    Console.WriteLine($"Level: {GetLevel()}");
}

    public int GetLevel()
{
    return (_score / 1000) + 1;
}
    public void SaveGoals()
{
    using (StreamWriter output = new StreamWriter("goals.txt"))
{
    output.WriteLine(_score);

    foreach (Goal goal in _goals)
{
    output.WriteLine(goal.GetStringRepresentation());
}
}

        Console.WriteLine("Goals saved.");
}

    public void LoadGoals()
{
    if (!File.Exists("goals.txt"))
{
    Console.WriteLine("No save file found.");
    return;
}

    _goals.Clear();

    string[] lines = File.ReadAllLines("goals.txt");

    _score = int.Parse(lines[0]);

    for (int i = 1; i < lines.Length; i++)
{
    string[] parts = lines[i].Split('|');

    if (parts[0] == "SimpleGoal")
{
    _goals.Add(
    new SimpleGoal(
    parts[1],
    parts[2],
    int.Parse(parts[3]),
    bool.Parse(parts[4])
  )
 );
}
    else if (parts[0] == "EternalGoal")
{
    _goals.Add(
    new EternalGoal(
    parts[1],
    parts[2],
    int.Parse(parts[3])
  )
 );
}
    else if (parts[0] == "ChecklistGoal")
{
_goals.Add(
    new ChecklistGoal(
    parts[1],
    parts[2],
    int.Parse(parts[3]),
    int.Parse(parts[4]),
    int.Parse(parts[5]),
    int.Parse(parts[6])
   )
  );
 }
}

Console.WriteLine("Goals loaded.");
 }
}