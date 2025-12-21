using System;

class Program
{
    static void Main()
    {
        int secretNumber = 7;   // secret number
        int guess;

        do
        {
            Console.Write("Guess the secret number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess != secretNumber)
            {
                Console.WriteLine("Wrong guess! Try again.");
            }

        } while (guess != secretNumber);

        Console.WriteLine("  You guessed the correct number.");
    }
}
