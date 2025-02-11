using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity {
    public GratitudeActivity(string name, string description) : base(name, description) { }

    public void DisplayGratitudeWelcomeMessage() {
        Console.WriteLine($"Welcome to {GetName()}!");
    }

    public void Run() {
        DisplayStartingMessage();
        Console.WriteLine("List things you are grateful for:");
        
        List<string> gratitudeList = new();
        string input;
        do {
            Console.Write("> ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) {
                gratitudeList.Add(input);
            }
        } while (!string.IsNullOrEmpty(input));

        Console.WriteLine($"You listed {gratitudeList.Count} things you are grateful for.");
        DisplayEndingMessage();
    }
}
