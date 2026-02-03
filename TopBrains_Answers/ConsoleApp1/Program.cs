using System;

public class MultiplicationTable
{
    // Method to return multiplication table row for n from 1 to upto
    public static int[] GetMultiplicationRow(int n, int upto)
    {
        // If upto is 0 or negative, return an empty array
        if (upto <= 0)
        {
            return new int[0];
        }

        int[] row = new int[upto];

        // Generate multiplication values
        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }

    public static void Main()
    {
        // Take user input
        Console.Write("Enter the number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the limit (upto): ");
        int upto = int.Parse(Console.ReadLine());

        int[] result = GetMultiplicationRow(n, upto);

        // Print using string interpolation ($)
        Console.Write("Multiplication table row: ");

        for (int i = 0; i < result.Length; i++)
        {
            // Print comma only between elements
            Console.Write($"{result[i]}");
            if (i < result.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }
}
