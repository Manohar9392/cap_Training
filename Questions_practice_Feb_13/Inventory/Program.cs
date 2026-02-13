using System;
using System.Collections.Generic;

class Inventory
{
    static void Main()
    {
        Console.Write("Enter serial numbers: ");
        var input = Console.ReadLine().Split();

        var seen = new HashSet<string>();
        var duplicates = new HashSet<string>();
        var result = new List<string>();

        foreach (var s in input)
        {
            if (!seen.Add(s) && duplicates.Add(s))
                result.Add(s);
        }

        Console.WriteLine("Duplicates:");
        Console.WriteLine(string.Join(" ", result));
    }
}
