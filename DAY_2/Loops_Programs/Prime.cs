using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        bool isPrime = true;

        // Numbers less than or equal to 1 are not prime
        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;   // exit loop when divisor is found
                }
            }
        }

        if (isPrime)
            Console.WriteLine($"{num} is a Prime number");
        else
            Console.WriteLine($"{num} is NOT a Prime number");
    }
}
