using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
    public class Journal
    {
        private List<JournalEntry> entries = new List<JournalEntry>();
        private List<string> prompts = new List<string>
        {
            "What Family did i visit Today?",
            "What was the best part of my day?",
            "What was the connection I made today?",
            "What Would i have done differently Today?",
            "How did I see the hand of the Lord in my life today?"
        };

        public void AddEntry()
        {
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            entries.Add(new JournalEntry(prompt, response));
            Console.WriteLine("Entry saved.\n");
        }

        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No entries in the journal.\n");
                return;
            }

            Console.WriteLine("Journal Entries:");
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveToFile()
        {
            Console.Write("Enter the filename to save the journal (e.g., journal.csv): ");
            string fileName = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToCsvFormat());
                }
            }

            Console.WriteLine("Journal saved successfully.\n");
        }

        public void LoadFromFile()
        {
            Console.Write("Enter the filename to load the journal: ");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.\n");
                return;
            }

            entries.Clear();
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                entries.Add(JournalEntry.FromCsvFormat(line));
            }

            Console.WriteLine("Journal loaded successfully.\n");
        }
    }
}
