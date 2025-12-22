using System;

class Program
{
    /// <summary>
    /// Calculates factorial using long
    /// </summary>
    /// <param name="n">Number</param>
    /// <returns>Factorial</returns>
    public static long Factorial(long n)
    {
        long fact = 1;
        for (long i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        long n = long.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else if (n > 20) // long overflow check
        {
            Console.WriteLine("Number too large for long. Use BigInteger version.");
        }
        else
        {
            long result = Factorial(n);
            Console.WriteLine($"{n}! = {result}");
        }
    }
}
