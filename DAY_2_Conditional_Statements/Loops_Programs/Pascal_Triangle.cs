using System;

class Program
{
    /// <summary>
    /// Prints Pascal's Triangle up to n rows
    /// </summary>
    /// <param name="n">Number of rows</param>
    public static void PrintPascalsTriangle(int n)
    {
        for (int i = 0; i < n; i++)
        {
            // Print leading spaces for alignment
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            int value = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(value + " ");
                // Compute next value in row using combinatorial formula
                value = value * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter number of rows for Pascal's Triangle: ");
        int rows = int.Parse(Console.ReadLine());

        PrintPascalsTriangle(rows);
    }
}
