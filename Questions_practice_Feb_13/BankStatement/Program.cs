using System;
using System.Collections.Generic;

class BankStatement
{
    static void Main()
    {
        Console.Write("Enter number of transactions: ");
        int n = int.Parse(Console.ReadLine());

        var transactions = new List<(string category, int amount)>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter category and amount: ");
            var input = Console.ReadLine().Split();

            string category = input[0];
            int amount = int.Parse(input[1]);

            transactions.Add((category, amount));
        }

        Dictionary<string, int> result = CalculateSpend(transactions);

        Console.WriteLine("Spend By Category:");
        foreach (var kv in result)
            Console.WriteLine($"{kv.Key} : {kv.Value}");
    }

    static Dictionary<string, int> CalculateSpend(
        List<(string category, int amount)> txns)
    {
        var spend = new Dictionary<string, int>();

        foreach (var (category, amount) in txns)
        {
            if (amount >= 0) continue;   // Ignore income

            int positiveAmount = -amount;

            if (spend.ContainsKey(category))
                spend[category] += positiveAmount;
            else
                spend[category] = positiveAmount;
        }

        return spend;
    }
}
