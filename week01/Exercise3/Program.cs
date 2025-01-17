using System;

class Program
{
    static void Main(string[] args)
    {
        {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random numbe
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 10);

        int guess = -1;

        
        while (guess != magicNumber)
        {
            Console.Write("Guess the Magic Number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"Yipee {magicNumber} You guessed right!");
            }

        }                    
        }
    }
}