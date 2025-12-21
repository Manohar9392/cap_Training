using System;

class Program
{
    static void Main()
    {
        int target = 7;
        bool found = false;

        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                for (int k = 1; k <= 3; k++)
                {
                    

                    if (i + j + k == target)
                    {
                        Console.WriteLine($"Target found at i={i}, j={j}, k={k}");
                        found = true;
                        goto FOUND;   // exit all loops instantly
                    }
                }
            }
        }

    FOUND:
        if (found)
            Console.WriteLine("Exited all loops using goto.");
        else
            Console.WriteLine("Target not found.");
    }
}
