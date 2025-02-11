using System;
using System.Collections.Generic;
using System.Threading;

public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }

    public Activity(string name, int duration) {
        _name = name;
        _duration = duration;
    }

    public Activity(int duration) {
        _duration = duration;
    }

    public string GetName() {
        return _name;
    }

    public void DisplayStartingMessage() {
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner() {
        List<string> rotation = new() { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.UtcNow.AddSeconds(5);
        int x = 0;

        while (DateTime.UtcNow < endTime) {
            Console.Write(rotation[x]);
            Thread.Sleep(500);
            Console.Write("\b");
            x = (x + 1) % rotation.Count;
        }
    }

    public void ShowCountDown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
