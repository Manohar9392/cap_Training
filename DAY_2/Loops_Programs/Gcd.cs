using System;

class Program
{
    /// <summary>
    /// Calculates the Greatest Common Divisor (GCD) of two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>GCD value</returns>
    public static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    /// <summary>
    /// Calculates the Least Common Multiple (LCM) of two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>LCM value</returns>
    public static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = FindGCD(num1, num2);
        int lcm = FindLCM(num1, num2);

        Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
    }
}
