using System;
using System.Collections.Generic;
using System.Linq;

class Leaderboard
{
    static void Main()
    {
        Console.Write("Enter number of players: ");
        int n = int.Parse(Console.ReadLine());

        var players = new List<(string name, int score)>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter name and score: ");
            var input = Console.ReadLine().Split();
            players.Add((input[0], int.Parse(input[1])));
        }

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        var topK = players
            .OrderByDescending(p => p.score)
            .ThenBy(p => p.name);

        Console.WriteLine("Top K Players:");
        for(int i=0;i<k;i++)
        {
            Console.WriteLine($"{topK.ElementAt(i).name} : {topK.ElementAt(i).score}");
        }
    }
}
