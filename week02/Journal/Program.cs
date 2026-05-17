// Exceeded requirements by:
// - Using random prompts
// - Saving and loading journal entries from files
// - Organizing the project with multiple classes and abstraction

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
         string choice = "";
         while (choice != "5")
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");

        choice = Console.ReadLine();
        

        if (choice == "1")
{
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);

        string response = Console.ReadLine();

        Entry newEntry = new Entry();

        newEntry._promptText = prompt;
        newEntry._entryText = response;
        newEntry._date = DateTime.Now.ToShortDateString();

        journal.AddEntry(newEntry);
}

else if (choice == "2")
{
    journal.DisplayAll();
}
else if (choice == "3")
{
    Console.WriteLine("Enter filename:");
    string file = Console.ReadLine();
    journal.SaveToFile(file);
}
else if (choice == "4")
{
    Console.WriteLine("Enter filename:");
    string file = Console.ReadLine();
    journal.LoadFromFile(file);
}
else if (choice == "5")
{
    Console.WriteLine("Goodbye!");
}
else
{
    Console.WriteLine("Invalid option. Try again.");
}
        }
    }
}