public class  BreathingActivity : Activity
{
public BreathingActivity()
: base(

    "Breathing Activity",
    "This activity will help you relax by walking you through breathing in and out slowly."
    )
{}

public void Run()
{
DisplayStartingMessage(); 
DateTime endTime = DateTime.Now.AddSeconds(_duration);
while (DateTime.Now < endTime)
{
Console.Write("Breathe in... ");
ShowCountDown(5);

Console.Write("Breathe out... ");
ShowCountDown(5);
}
DisplayEndingMessage();
    }

}
