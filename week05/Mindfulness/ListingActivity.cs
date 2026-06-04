public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
        _prompts = new List<string>();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
       DisplayStartingMessage();
       Random random = new Random();

       int index = random.Next(_prompts.Count);
       Console.WriteLine($"List as many responses as you can to the following prompt:");
       Console.WriteLine($"--- {_prompts[index]} ---");
       Console.WriteLine();

       Console.WriteLine("You may begin in:");
       ShowCountDown(5);

       List<string> items = new List<string>();
       DateTime endTime = DateTime.Now.AddSeconds(_duration);

 while (DateTime.Now < endTime)
{
    string item = Console.ReadLine();
    items.Add(item);
}

Console.WriteLine();
Console.WriteLine($"You listed {items.Count} items!");

DisplayEndingMessage();
    }
}