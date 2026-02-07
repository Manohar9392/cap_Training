using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

#region Entity

// Represents error code summary
public class ErrorSummary
{
    public string ErrorCode { get; set; }
    public int Count { get; set; }
}

#endregion

#region Log Analyzer

public class LogAnalyzer
{
    // Main method (streaming + memory safe)
    public IEnumerable<ErrorSummary> GetTopErrors(
        string filePath, int topN)
    {
        // Dictionary to store error counts
        Dictionary<string, int> errorCounts =
            new Dictionary<string, int>();

        // Regex to match error codes like ERR123
        Regex errorRegex = new Regex(
            @"ERR\d+", RegexOptions.Compiled);

        // STREAM the file line-by-line (no full load)
        foreach (string line in File.ReadLines(filePath))
        {
            // Find all error codes in the line
            MatchCollection matches =
                errorRegex.Matches(line);

            foreach (Match match in matches)
            {
                string errorCode = match.Value;

                if (errorCounts.ContainsKey(errorCode))
                    errorCounts[errorCode]++;
                else
                    errorCounts[errorCode] = 1;
            }
        }

        // Return Top N errors by frequency
        return errorCounts
            .OrderByDescending(e => e.Value)
            .Take(topN)
            .Select(e => new ErrorSummary
            {
                ErrorCode = e.Key,
                Count = e.Value
            });
    }
}

#endregion

#region Program (Demo)

class Program
{
    static void Main()
    {
        // Sample file path (replace with real large log file)
        string filePath = "application.log";

        LogAnalyzer analyzer = new LogAnalyzer();

        var topErrors =
            analyzer.GetTopErrors(filePath, 5);

        Console.WriteLine("Top Errors:");
        foreach (var error in topErrors)
        {
            Console.WriteLine(
                $"{error.ErrorCode} -> {error.Count}");
        }
    }
}

#endregion
