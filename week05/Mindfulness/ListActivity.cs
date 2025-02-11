using System;
using System.Collections.Generic;

public class ListActivity : Activity {
    private List<string> _prompts = new() {
        "When have you felt the Holy Ghost in your life?",
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public ListActivity(string name, string description) : base(name, description) { }

    public void DisplayListActivityWelcomeMessage() {
        Console.WriteLine($"Welcome to {GetName()}!");
    }

    public void Run() {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin listing your answers: ");
        
        List<string> responses = new();
        string input;
        do {
            Console.Write("> ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) {
                responses.Add(input);
            }
        } while (!string.IsNullOrEmpty(input));

        Console.WriteLine($"You have listed {responses.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() {
        Random random = new();
        return _prompts[random.Next(_prompts.Count)];
    }
}
