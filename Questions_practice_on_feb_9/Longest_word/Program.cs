using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter the para: ");
        string input = Console.ReadLine();  
        string[] words = input.Split(' ');
        string longestWord = "";
        foreach(string v in words)
        {
            if(v.Length > longestWord.Length)
            {
                longestWord = v;
            }
        }
        Console.WriteLine("The longest word is: " + longestWord);

    }
}