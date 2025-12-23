using System;

class Program
{
    /// <summary>
    /// Prints the first n terms of the Fibonacci sequence
    /// </summary>
    /// <param name="n">Number of terms</param>
    public static void PrintFibonacci(int n)
    {
        int a = 0, b = 1;

        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        Console.WriteLine("Fibonacci sequence:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        PrintFibonacci(n);
    }
}
