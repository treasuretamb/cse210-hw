using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the lucky number? ");
        int magicNumber;

        while (!int.TryParse(Console.ReadLine(), out magicNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write("What is the lucky number? ");
        }

        Random random = new Random();
        int targetNumber = random.Next(1, 101);

        int userGuess;

        do
        {
            Console.Write("What is your guess? ");
            
            while (!int.TryParse(Console.ReadLine(), out userGuess))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("What is your guess? ");
            }

            if (userGuess < targetNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > targetNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (userGuess != targetNumber);
    }
}