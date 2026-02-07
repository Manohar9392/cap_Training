using System;
using System.Collections.Generic;

#region Entities

public class Customer
{
    public string CustomerId { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}

public class DuplicateGroup
{
    public List<Customer> Customers { get; set; }
        = new List<Customer>();
}

#endregion

#region Duplicate Detection Logic

public class DuplicateDetectionService
{
    public List<DuplicateGroup> FindDuplicates(List<Customer> customers)
    {
        List<DuplicateGroup> result = new List<DuplicateGroup>();
        bool[] visited = new bool[customers.Count];

        for (int i = 0; i < customers.Count; i++)
        {
            if (visited[i])
                continue;

            DuplicateGroup group = new DuplicateGroup();
            group.Customers.Add(customers[i]);
            visited[i] = true;

            for (int j = i + 1; j < customers.Count; j++)
            {
                if (visited[j])
                    continue;

                if (IsDuplicate(customers[i], customers[j]))
                {
                    group.Customers.Add(customers[j]);
                    visited[j] = true;
                }
            }

            // Only consider groups with duplicates
            if (group.Customers.Count > 1)
            {
                result.Add(group);
            }
        }

        return result;
    }

    private bool IsDuplicate(Customer c1, Customer c2)
    {
        // Rule 1: Same phone
        if (!string.IsNullOrEmpty(c1.Phone) &&
            c1.Phone == c2.Phone)
            return true;

        // Rule 2: Same email
        if (!string.IsNullOrEmpty(c1.Email) &&
            c1.Email.Equals(c2.Email,
                StringComparison.OrdinalIgnoreCase))
            return true;

        // Rule 3: Name similarity >= 80%
        double similarity = CalculateNameSimilarity(
            c1.Name, c2.Name);

        return similarity >= 0.80;
    }

    // Convert edit distance to similarity percentage
    private double CalculateNameSimilarity(string s1, string s2)
    {
        int distance = EditDistance(
            s1.ToLower(), s2.ToLower());

        int maxLength = Math.Max(s1.Length, s2.Length);

        if (maxLength == 0)
            return 1.0;

        return 1.0 - ((double)distance / maxLength);
    }

    // Levenshtein Edit Distance
    private int EditDistance(string s1, string s2)
    {
        int[,] dp = new int[s1.Length + 1, s2.Length + 1];

        for (int i = 0; i <= s1.Length; i++)
            dp[i, 0] = i;

        for (int j = 0; j <= s2.Length; j++)
            dp[0, j] = j;

        for (int i = 1; i <= s1.Length; i++)
        {
            for (int j = 1; j <= s2.Length; j++)
            {
                if (s1[i - 1] == s2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1];
                else
                    dp[i, j] = 1 + Math.Min(
                        dp[i - 1, j - 1],
                        Math.Min(dp[i - 1, j], dp[i, j - 1]));
            }
        }

        return dp[s1.Length, s2.Length];
    }
}

#endregion

#region Program (Demo)

class Program
{
    static void Main()
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer
            {
                CustomerId = "C1",
                Name = "Rahul Sharma",
                Phone = "9999999999",
                Email = "rahul@gmail.com"
            },
            new Customer
            {
                CustomerId = "C2",
                Name = "Rahul S.",
                Phone = "9999999999",
                Email = "rahul.s@gmail.com"
            },
            new Customer
            {
                CustomerId = "C3",
                Name = "Rohit Verma",
                Phone = "8888888888",
                Email = "rohit@gmail.com"
            },
            new Customer
            {
                CustomerId = "C4",
                Name = "Rahul Sharma",
                Phone = "7777777777",
                Email = "rahul@gmail.com"
            }
        };

        DuplicateDetectionService service =
            new DuplicateDetectionService();

        var duplicates = service.FindDuplicates(customers);

        Console.WriteLine("Duplicate Groups:\n");

        int groupNo = 1;
        foreach (var group in duplicates)
        {
            Console.WriteLine($"Group {groupNo++}:");
            foreach (var c in group.Customers)
            {
                Console.WriteLine(
                    $"  {c.CustomerId} | {c.Name} | {c.Phone} | {c.Email}");
            }
            Console.WriteLine();
        }
    }
}

#endregion
