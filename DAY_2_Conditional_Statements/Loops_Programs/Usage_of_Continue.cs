using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Numbers from 1 to 50, skipping multiples of 3:");

        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0)
            {
                continue; // skip multiples of 3
            }

            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}
