using System;
using System.Collections.Generic;

public class ReflectActivity : Activity {
    private List<string> _prompts = new() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new() {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    public ReflectActivity(string name, string description) : base(name, description) { }

    public void DisplayReflectingWelcomeMessage() {
        Console.WriteLine($"Welcome to {GetName()}!");
    }

    public void Run() {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        
        Console.WriteLine("Now, ponder these questions:");
        foreach (string question in _questions) {
            Console.WriteLine($"- {question}");
            ShowSpinner();
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt() {
        Random random = new();
        return _prompts[random.Next(_prompts.Count)];
    }
}
