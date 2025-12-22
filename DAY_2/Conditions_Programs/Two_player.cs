using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Player 1: Enter your choice (rock/paper/scissors): ");
        string player1 = Console.ReadLine().ToLower();

        Console.WriteLine("Player 2: Enter your choice (rock/paper/scissors): ");
        string player2 = Console.ReadLine().ToLower();

        if (player1 == player2)
        {
            Console.WriteLine("It's a tie!");
        }
        else
        {
            if (player1 == "rock")
            {
                if (player2 == "scissors")
                    Console.WriteLine("Player 1 wins!");
                else // player2 == paper
                    Console.WriteLine("Player 2 wins!");
            }
            else if (player1 == "paper")
            {
                if (player2 == "rock")
                    Console.WriteLine("Player 1 wins!");
                else // player2 == scissors
                    Console.WriteLine("Player 2 wins!");
            }
            else if (player1 == "scissors")
            {
                if (player2 == "paper")
                    Console.WriteLine("Player 1 wins!");
                else // player2 == rock
                    Console.WriteLine("Player 2 wins!");
            }
            else
            {
                Console.WriteLine("Invalid input by Player 1!");
            }
        }
    }
}
