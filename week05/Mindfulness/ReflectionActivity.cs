using System.Security.Cryptography.X509Certificates;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectionActivity()
    : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience."
    )
{
    _prompts = new List<string>();

    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");

    _questions = new List<string>();

    _questions.Add("Why was this experience meaningful to you?");
    _questions.Add("Have you ever done anything like this before?");
    _questions.Add("How did you get started?");
    _questions.Add("How did you feel when it was complete?");
    _questions.Add("What did you learn about yourself through this experience?");
}
    public void Run()
{
    DisplayStartingMessage();

    Random random = new Random();
    int index = random.Next(_prompts.Count);
    Console.WriteLine();
    Console.WriteLine("Reflect on the following prompt:");
    Console.WriteLine($"--- {_prompts[index]} ---");
    Console.WriteLine();

    Console.WriteLine("When you have something in mind, press Enter to continue.");
    Console.ReadLine();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
        {
            int questionIndex = random.Next(_questions.Count);
            Console.WriteLine(_questions[questionIndex]);
            ShowSpinner(5);
        }
        DisplayEndingMessage();
}
  }
   