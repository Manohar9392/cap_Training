using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter the sentence: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        Dictionary<string,int> wordCount = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount.Add(word,1);
            }
        }
        Console.WriteLine("Word Count:");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

    }
}