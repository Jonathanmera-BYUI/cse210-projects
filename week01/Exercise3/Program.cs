using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
    string magicAnswer = Console.ReadLine();
    int magicNumber = int.Parse(magicAnswer);

        Console.Write("What is your guess? ");
    string guessAnswer = Console.ReadLine();
    int guess = int.Parse(guessAnswer); 

    while (guess != magicNumber)
{

    if (guess < magicNumber)
{
    Console.WriteLine("Higher");
}
else if (guess > magicNumber)
{
    Console.WriteLine("Lower");
}
 Console.Write("What is your guess? ");
            guessAnswer = Console.ReadLine();
            guess = int.Parse(guessAnswer);
        }

        Console.WriteLine("You guessed it!");
    }
}