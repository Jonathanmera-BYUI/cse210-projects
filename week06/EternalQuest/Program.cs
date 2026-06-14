// Exceeding Requirements:
// Added a scoring system to track points.
// Added a level system based on total score.
// Added save and load functionality so goals
// can persist between program executions.

using System;

class Program
{
    static void Main(string[] args)
{
    GoalManager manager = new GoalManager();
    int choice = 0;

    while (choice != 9)
{
    Console.WriteLine();
    Console.WriteLine("1. Create Simple Goal");
    Console.WriteLine("2. Create Eternal Goal");
    Console.WriteLine("3. Create Checklist Goal");
    Console.WriteLine("4. Show Goals");
    Console.WriteLine("5. Record Event");
    Console.WriteLine("6. Show Score");
    Console.WriteLine("7. Save Goals");
    Console.WriteLine("8. Load Goals");
    Console.WriteLine("9. Quit");
    Console.Write("Choose an option: ");

    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
{
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Description: ");
    string description = Console.ReadLine();

    Console.Write("Points: ");
    int points = int.Parse(Console.ReadLine());

    manager.AddGoal(new SimpleGoal(name, description, points));
}
    else if (choice == 2)
{
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Description: ");
    string description = Console.ReadLine();

    Console.Write("Points: ");
    int points = int.Parse(Console.ReadLine());

    manager.AddGoal(new EternalGoal(name, description, points));
}
    else if (choice == 3)
{
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Description: ");
    string description = Console.ReadLine();

    Console.Write("Points: ");
    int points = int.Parse(Console.ReadLine());

    Console.Write("Target Amount: ");
    int targetAmount = int.Parse(Console.ReadLine());

    Console.Write("Bonus: ");
    int bonus = int.Parse(Console.ReadLine());

    manager.AddGoal(
    new ChecklistGoal(
    name,
    description,
    points,
    targetAmount,
    bonus
  )
 );
}
    else if (choice == 4)
{
    manager.DisplayGoals();
}
    else if (choice == 5)
{
    manager.DisplayGoals();

    Console.Write("Select goal: ");
    int goalNumber = int.Parse(Console.ReadLine());

    manager.RecordEvent(goalNumber - 1);
}
    else if (choice == 6)
{
    manager.DisplayScore();
}
    else if (choice == 7)
{
    manager.SaveGoals();
}
    else if (choice == 8)
{
    manager.LoadGoals();
   }
  }
 }
}