using System;
using System.Collections.Generic;
using System.Linq;

class TicketMerge
{
    static void Main()
    {
        Console.Write("Enter first sorted list: ");
        var a = Console.ReadLine().Split().Select(int.Parse).ToList();

        Console.Write("Enter second sorted list: ");
        var b = Console.ReadLine().Split().Select(int.Parse).ToList();

        var result = new List<int>();
        int i = 0, j = 0;

        while (i < a.Count && j < b.Count)
        {
            if (a[i] <= b[j])
                result.Add(a[i++]);
            else
                result.Add(b[j++]);
        }

        while (i < a.Count) result.Add(a[i++]);
        while (j < b.Count) result.Add(b[j++]);

        Console.WriteLine("Merged:");
        Console.WriteLine(string.Join(" ", result));
    }
}
