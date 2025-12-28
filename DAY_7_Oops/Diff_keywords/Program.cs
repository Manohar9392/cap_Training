using System;
using Keywords;

public class Program
{
    public static void Main(string[] args)
    {
        keys k = new keys();
        int square, half, cube;
        k.Multimath(4, out square, out half, out cube);
        Console.WriteLine("Square: " + square);
        Console.WriteLine("Half: " + half);
        Console.WriteLine("Cube: " + cube);

        // Demonstrating checked keyword
        int a=int.MaxValue;
        int b=1;
        try
        {
            k.Key_checked(a, b);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Overflow occurred: " + ex.Message);
        }

        // Demonstrating ref keyword
        int num = 10;   
        Console.WriteLine("Before ref method call: " + num);
        k.Key_ref_example(ref num); 
        Console.WriteLine("After ref method call: " + num);

        // Without ref keyword
        int num2 = 10;
        Console.WriteLine("Before without ref method call: " + num2);
        k.Without_ref_example(num2);
        Console.WriteLine("After without ref method call: " + num2);
        


    }
}