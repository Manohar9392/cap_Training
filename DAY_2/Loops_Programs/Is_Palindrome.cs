using System;

class Program
{
    /// <summary>
    /// Reverses an integer
    /// </summary>
    /// <param name="num">Input number</param>
    /// <returns>Reversed number</returns>
    public static int ReverseNumber(int num)
    {
        int reversed = 0;
        int temp = num;

        while (temp != 0)
        {
            int digit = temp % 10;
            reversed = reversed * 10 + digit;
            temp /= 10;
        }

        return reversed;
    }

    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine($"Reversed Number: {reversedNumber}");

        if (number == reversedNumber)
        {
            Console.WriteLine($"{number} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a palindrome.");
        }
    }
}
