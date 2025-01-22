using System;

namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            while (true)
            {
                Console.WriteLine("Journal App Menu:");
                Console.WriteLine("1. Write ");
                Console.WriteLine("2. Display ");
                Console.WriteLine("3. Save ");
                Console.WriteLine("4. Load ");
                Console.WriteLine("5. Exit ");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.AddEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }
    }
}
