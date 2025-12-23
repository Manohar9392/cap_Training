using System;

class Program
{
    /// <summary>
    /// Checks whether a number equals the sum of its digits raised to the power of number of digits
    /// </summary>
    /// <param name="num">Input number</param>
    /// <returns>true if Armstrong number, false otherwise</returns>
    public static bool IsArmstrong(int num)
    {
        int originalNum = num;
        int sum = 0;

        // Count number of digits
        int digits = num.ToString().Length;

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digits);
            num /= 10;
        }

        return sum == originalNum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsArmstrong(number))
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT an Armstrong number.");
        }
    }
}
