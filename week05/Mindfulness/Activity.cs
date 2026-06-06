using System;
using System.Threading;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
{
    _name = name;
    _description = description;
}
public void DisplayStartingMessage()
    {
    Console.Clear();

    Console.WriteLine($"Welcome to the {_name}.");
    Console.WriteLine();

    Console.WriteLine(_description);
    Console.WriteLine();

    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Get ready...");
    ShowSpinner(3);
    }
public void DisplayEndingMessage()
    {
    Console.WriteLine();
    Console.WriteLine("Well done!!");
    ShowSpinner(3);
    Console.WriteLine();
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    ShowSpinner(3);
    }
public void ShowSpinner(int seconds)
{
    string[] spinner = { "|", "/", "-", "\\" };
    DateTime endTime = DateTime.Now.AddSeconds(seconds);
    while (DateTime.Now < endTime)
{
    foreach (string symbol in spinner)
    {
        Console.Write(symbol);
        Thread.Sleep(250);
        Console.Write("\b \b");
    }
}
}
public void ShowCountDown(int seconds)
{
    for (int i = seconds; i >= 1; i--)
{
    Console.Write(i);
    Thread.Sleep(1000);
    Console.Write("\b \b");
}
    Console.WriteLine();
}
}