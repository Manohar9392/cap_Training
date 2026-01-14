using System;
// using model;


public class Program
{

    public delegate void PrintMessage(string message);
    
        

    // private static string Method1(string message)
    // {
    //     return $"hello {message}";
    // } 
    
    // private static string HappyNewYear(string message)
    // {
    //     return $"Happy new year {message}";
    // }
    /// <summary>
    /// Products function []
    /// </summary>
    /// <param name="message"></param>

    static void Products(string message)
    {
        Console.WriteLine( $"{message} added");
    }
    static void cash(string message)
    {
        Console.WriteLine($"{message} money received");
    }
    static void Delivery(string message)
    {
        Console.WriteLine( $"{message} Delivered");
    }

    public static void Main(string[] args)
    {
        // PrintProgram p1=new PrintProgram();

        // p1.CustomerChoice=new PrintMessage(Method1);
        // p1.prints("ram");
        // p1.CustomerChoice=new PrintMessage(HappyNewYear);
        // p1.prints("ram");

        PrintMessage p2=new PrintMessage(Products);
        p2+=new PrintMessage(cash);
        p2+=new PrintMessage(Delivery);

        Console.Write("Enter the product: ");
        string input=Console.ReadLine();

        p2(input);

    }
}