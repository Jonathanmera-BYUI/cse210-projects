// Exceeding Requirements:
// I added a Gratitude Activity that helps users focus on
// things they are grateful for. This activity inherits
// from the Activity base class and uses the common
// functionality shared by all activities.

using System;
using System.Reflection.Metadata;

class Program
{
   static void Main(string[] args)
{
string choice = "";

while (choice != "4")
{
Console.Clear();

Console.WriteLine("1. Start Breathing Activity");
Console.WriteLine("2. Start Reflection Activity");
Console.WriteLine("3. Start Listing Activity");
Console.WriteLine("4. Start Gratitude Activity");
Console.WriteLine("5. Quit");

choice = Console.ReadLine();

    if (choice == "1")
{
    BreathingActivity breathing = new BreathingActivity();
    breathing.Run();
}
    else if (choice == "2")
{
    ReflectionActivity reflection = new ReflectionActivity();
    reflection.Run(); 
}

    else if (choice == "3")
{
    ListingActivity listing = new ListingActivity();
    listing.Run(); 
}

    else if (choice == "4")
{
    GratitudeActivity gratitude = new GratitudeActivity();
    gratitude.Run();
}
   }
  }
 }
