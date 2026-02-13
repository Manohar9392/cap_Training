using System;
using System.Collections.Generic;

class MetroTicketing
{
    static void Main()
    {
        Console.Write("Enter number of passengers: ");
        int n = int.Parse(Console.ReadLine());

        var queue = new Queue<(TimeSpan, string)>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter time(HH:mm) and ticket type: ");
            var input = Console.ReadLine().Split();
            queue.Enqueue((TimeSpan.Parse(input[0]), input[1]));
        }

        TimeSpan start = new TimeSpan(8, 0, 0);
        TimeSpan end = new TimeSpan(10, 0, 0);

        int count = 0;

        while (queue.Count > 0)
        {
            var (time, type) = queue.Dequeue();
            if (type == "Regular" && time >= start && time <= end)
                count++;
        }

        Console.WriteLine("Peak Regular Count: " + count);
    }
}
