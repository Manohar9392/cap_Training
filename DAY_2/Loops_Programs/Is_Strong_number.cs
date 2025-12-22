using System;

class Program
{
    /// <summary>
    /// Calculates factorial of a single digit
    /// </summary>
    public static int Factorial(int digit)
    {
        int fact = 1;
        for (int i = 1; i <= digit; i++)
        {
            fact *= i;
        }
        return fact;
    }

    /// <summary>
    /// Checks whether the sum of factorials of digits equals the number itself
    /// </summary>
    public static bool IsStrongNumber(int num)
    {
        int sum = 0;
        int temp = num;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }

        return sum == num;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsStrongNumber(number))
        {
            Console.WriteLine($"{number} is a Strong Number.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a Strong Number.");
        }
    }
}
