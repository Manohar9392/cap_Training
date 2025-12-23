using System;

class Program
{
    /// <summary>
    /// Converts a binary string to its decimal equivalent
    /// </summary>
    /// <param name="binary">Binary number as string</param>
    /// <returns>Decimal value</returns>
    public static int BinaryToDecimal(string binary)
    {
        int decimalValue = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            decimalValue = decimalValue * 2 + (binary[i] - '0');
        }

        return decimalValue;
    }

    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();

        int decimalResult = BinaryToDecimal(binary);

        Console.WriteLine($"Decimal equivalent: {decimalResult}");
    }
}
