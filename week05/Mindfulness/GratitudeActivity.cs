// Exceeding Requirements:
// Added a Gratitude Activity that helps users
// reflect on blessings and positive things in their lives.
// This activity also uses inheritance from the Activity class.

using System;

public class GratitudeActivity : Activity
{
public GratitudeActivity()
    : base(
    "Gratitude Activity",
    "This activity will help you focus on things you are grateful for."
  )
 {
}

public void Run()
{
DisplayStartingMessage();

List<string> gratitudeItems = new List<string>();

Console.WriteLine();
Console.WriteLine("List 3 things you are grateful for:");

for (int i = 0; i < 3; i++)
{
    Console.Write($"> ");
    gratitudeItems.Add(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("You are grateful for:");

foreach (string item in gratitudeItems)
{
    Console.WriteLine($"- {item}");
}

  DisplayEndingMessage();
 }
}