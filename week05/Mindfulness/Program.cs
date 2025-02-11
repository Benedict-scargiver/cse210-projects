using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1 - Breathing Activity");
            Console.WriteLine("2 - Reflecting Activity");
            Console.WriteLine("3 - Listing Activity");
            Console.WriteLine("4 - Gratitude Activity");
            Console.WriteLine("5 - Quit");
            Console.Write("Select an option: ");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice == 5) {
                break;
            }

            Console.Clear();
            switch (choice) {
                case 1:
                    new BreathingActivity("Breathing Activity", "A relaxation exercise.").Run();
                    break;
                case 2:
                    new ReflectActivity("Reflecting Activity", "Think about meaningful experiences.").Run();
                    break;
                case 3:
                    new ListActivity("Listing Activity", "List your thoughts and memories.").Run();
                    break;
                case 4:
                    new GratitudeActivity("Gratitude Activity", "List things you're grateful for.").Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
// I added a new activity GRATITUDE ACTIVITY to the MINDFULNESS PROJECT