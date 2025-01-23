using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _promptText = promptText;
        _entryText = entryText;
    }

    public string ToCsv()
    {
        return $"{_date},{_promptText},{_entryText}";
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(new string('-', 40));
    }

    public static Entry FromCsv(string csvLine)
    {
        string[] parts = csvLine.Split(',');
        if (parts.Length < 3) return null;
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}
