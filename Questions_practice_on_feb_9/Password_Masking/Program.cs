using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter the word: ");
        string input = Console.ReadLine();
        string maskedWord = "";
        for(int i = 0; i < input.Length; i++)
        {
            if(i == 0 || i==input.Length-1)
            {
                maskedWord += input[i];
            }
            else
            {
                maskedWord += "*";
            }
        }
        Console.WriteLine("The longest word is: " + maskedWord);

    }
}