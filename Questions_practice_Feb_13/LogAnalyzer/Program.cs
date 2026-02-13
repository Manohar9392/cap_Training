using System;
using System.Collections.Generic;
using System.Linq;

class LogAnalyzer
{
    static void Main()
    {
        Console.Write("Enter error codes: ");
        var codes = Console.ReadLine().Split();

        var freq = new Dictionary<string, int>();

        foreach (var code in codes)
        {
            if (freq.ContainsKey(code))
                freq[code]++;
            else
                freq[code] = 1;
        }

        int max = freq.Values.Max();

        string result = freq
            .Where(x => x.Value == max)
            .OrderBy(x => x.Key)
            .First().Key;

        Console.WriteLine("Most Frequent: " + result);
    }
}
