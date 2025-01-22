using System;

namespace Journal
{
    public class JournalEntry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        public JournalEntry(string prompt, string response)
        {
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}, Prompt: {Prompt}, Response: {Response}";
        }

        public string ToCsvFormat()
        {
            return $"{Date},{Prompt},{Response}";
        }

        public static JournalEntry FromCsvFormat(string csvLine)
        {
            var parts = csvLine.Split(',');
            return new JournalEntry(parts[1], parts[2])
            {
                Date = DateTime.Parse(parts[0])
            };
        }
    }
}
