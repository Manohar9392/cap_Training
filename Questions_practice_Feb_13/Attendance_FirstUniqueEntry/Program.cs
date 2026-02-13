using System;
using System.Collections.Generic;

class Attendance
{
    static void Main()
    {
        Console.Write("Enter IDs (space separated): ");
        var input = Console.ReadLine().Split(" ");

        var scans = new List<int>();
        var firstTime = new List<int>();

        // Convert input to list
        foreach (var id in input)
            scans.Add(int.Parse(id));

        // Only using List (no HashSet)
        foreach (var id in scans)
        {
            if (!firstTime.Contains(id))
                firstTime.Add(id);
        }

        Console.WriteLine("First Unique Entries:");
        foreach(var v in firstTime)
        {
            Console.Write(v+" ");
        }
    }
}
