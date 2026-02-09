using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter the email: ");
        string input = Console.ReadLine();
        input = input.Trim();
        input = input.ToLower();
        input= input.Replace("gmail.com", "company.com");

        Console.WriteLine("The longest word is: " + input);

    }
}