using System;
using System.Collections.Generic;

class CartConsolidation
{
    static void Main()
    {
        Console.Write("Enter number of scans: ");
        int n = int.Parse(Console.ReadLine());

        var scans = new List<(string sku, int qty)>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter SKU and Quantity: ");
            var input = Console.ReadLine().Split();
            scans.Add((input[0], int.Parse(input[1])));
        }

        var result = Consolidate(scans);

        Console.WriteLine("Consolidated Cart:");
        foreach (var kv in result)
            Console.WriteLine($"{kv.Key} : {kv.Value}");
    }

    static Dictionary<string, int> Consolidate(List<(string sku, int qty)> scans)
    {
        var dict = new Dictionary<string, int>();

        foreach (var (sku, qty) in scans)
        {
            if (qty <= 0) continue;

            if (dict.ContainsKey(sku))
                dict[sku] += qty;
            else
                dict[sku] = qty;
        }

        return dict;
    }
}
