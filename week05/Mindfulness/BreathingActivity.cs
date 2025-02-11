using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }
    public BreathingActivity(int time) : base(time) { }
    public BreathingActivity(string name, int time) : base(name, time) { }

    public void DisplayBreathingWelcomeMessage()
    {
        Console.WriteLine($"Welcome to {GetName()}!");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? : ");
        int duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Getting ready...");
        ShowCountDown(3);

        for (int i = 0; i < duration / 4; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(2);
        }

        DisplayEndingMessage();
    }
}
