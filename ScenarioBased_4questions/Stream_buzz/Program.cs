using System;
using System.Collections.Generic;

public class CreatorStats
{
    // Name of the content creator
    public string? CreatorName { get; set; }

    // Array storing weekly likes for the creator
    public double[] WeeklyLikes { get; set; }

    // Default constructor
    public CreatorStats()
    {
    }

    // Parameterized constructor
    public CreatorStats(string? creatorName, double[] weeklyLikes)
    {
        CreatorName = creatorName;
        WeeklyLikes = weeklyLikes;
    }

    // Static list to store all registered creators
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

    // Registers a creator into the EngagementBoard
    public void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
        Console.WriteLine("User Registered Successfully");
    }

    // Returns count of weekly posts whose likes are above a given threshold
    public Dictionary<string, int> GetTopPostCounts(
        List<CreatorStats> records,
        double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var creator in records)
        {
            int count = 0;

            // Count how many weekly likes meet the threshold
            foreach (var like in creator.WeeklyLikes)
            {
                if (like >= likeThreshold)
                {
                    count++;
                }
            }

            // Add creator only if at least one post qualifies
            if (count > 0 && creator.CreatorName != null)
            {
                result.Add(creator.CreatorName, count);
            }
        }

        return result;
    }

    // Calculates the average likes across all creators and all weeks
    public double CalculateAverageLikes()
    {
        int count = 0;
        double totalLikes = 0;

        foreach (var creator in EngagementBoard)
        {
            foreach (var like in creator.WeeklyLikes)
            {
                totalLikes += like;
                count++;
            }
        }

        // Avoid division by zero
        return count > 0 ? totalLikes / count : 0;
    }
}

public class Program
{
    public static void Main()
    {
        CreatorStats manager = new CreatorStats();

        // Creating creator records
        CreatorStats creator1 = new CreatorStats(
            "Alice",
            new double[] { 120, 200, 150, 90, 300 }
        );

        CreatorStats creator2 = new CreatorStats(
            "Bob",
            new double[] { 80, 60, 110, 130, 95 }
        );

        // Register creators
        manager.RegisterCreator(creator1);
        manager.RegisterCreator(creator2);

        Console.WriteLine();

        // Get top post counts above a threshold
        double threshold = 100;
        Dictionary<string, int> topPosts =
            manager.GetTopPostCounts(
                CreatorStats.EngagementBoard,
                threshold
            );

        Console.WriteLine($"Posts with likes >= {threshold}:");
        foreach (var entry in topPosts)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value} posts");
        }

        Console.WriteLine();

        // Calculate and display average likes
        double averageLikes = manager.CalculateAverageLikes();
        Console.WriteLine($"Average Likes Across All Creators: {averageLikes}");
        Console.ReadLine();
    }
}
