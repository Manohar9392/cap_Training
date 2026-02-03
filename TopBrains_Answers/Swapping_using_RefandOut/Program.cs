using System;

class Swapping
{
    // Method 1: Swap using ref (no temp variable)
    static void SwapUsingRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    // Method 2: Swap using out
    static void SwapUsingOut(int a, int b, out int x, out int y)
    {
        // Assign swapped values
        x = b;
        y = a;
    }

    static void Main()
    {
        // ----------- REF METHOD -----------
        Console.Write("Enter first number (ref): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter second number (ref): ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before Swap (ref): x = {x}, y = {y}");

        SwapUsingRef(ref x, ref y);

        Console.WriteLine($"After Swap (ref): x = {x}, y = {y}");

        // ----------- OUT METHOD -----------
        Console.Write("\nEnter first number (out): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Enter second number (out): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before Swap (out): m = {m}, n = {n}");

        SwapUsingOut(m, n, out m, out n);

        Console.WriteLine($"After Swap (out): m = {m}, n = {n}");
    }
}
