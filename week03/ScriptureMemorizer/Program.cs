using System;

class Program
{
    
    static void Main(string[] args)
    
    {
        Console.WriteLine("Press ENTER to hide words or type 'quit' to exit");
        Reference reference = new Reference("Moroni", 10, 4);

        Scripture scripture = new Scripture(
        reference,
        "And when ye shall receive these things"
    );
string input = "";

    while (input != "quit" && !scripture.IsCompletelyHidden())
{
   Console.WriteLine(scripture.GetDisplayText());
   input = Console.ReadLine().Trim().ToLower();
   if (input != "quit")
{
    scripture.HideRandomWords();
}
}
    }
    
}
