using System;

class Program
{
    /// <summary>
    /// Prints a diamond pattern of given size
    /// </summary>
    /// <param name="n">Number of rows in the upper half</param>
    public static void PrintDiamond(int n)
    {
        // Upper half of the diamond
        for (int i = 1; i <= n; i++)
        {
            // Print leading spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Lower half of the diamond
        for (int i = n - 1; i >= 1; i--)
        {
            // Print leading spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter the number of rows for the upper half of the diamond: ");
        int rows = int.Parse(Console.ReadLine());

        PrintDiamond(rows);
    }
}
