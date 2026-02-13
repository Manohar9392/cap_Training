using System;
using System.Collections.Generic;
using System.Linq;

class SeatAllocator
{
    static void Main()
    {
        Console.Write("Enter total seats: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter already booked seats: ");
        var booked = Console.ReadLine().Split().Select(int.Parse).ToList();

        Console.Write("Enter request count: ");
        int requests = int.Parse(Console.ReadLine());

        var available = new SortedSet<int>(Enumerable.Range(1, n));
        foreach (var seat in booked)
            available.Remove(seat);

        for (int i = 0; i < requests; i++)
        {
            if (available.Count == 0)
                Console.WriteLine(-1);
            else
            {
                int seat = available.Min;
                Console.WriteLine(seat);
                available.Remove(seat);
            }
        }
    }
}
