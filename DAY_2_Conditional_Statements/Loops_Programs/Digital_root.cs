using System;

class Program
{
    /// <summary>
    /// Calculates the digital root of a number
    /// </summary>
    /// <param name="num">Non-negative integer</param>
    /// <returns>Single digit digital root</returns>
    public static int DigitalRoot(int num)
    {
        while (num >= 10)   // Repeat until single digit
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            num = sum;
        }

        return num;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Please enter a non-negative number.");
            return;
        }

        int result = DigitalRoot(number);
        Console.WriteLine($"Digital Root: {result}");
    }
}
