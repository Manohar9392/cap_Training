using System;

class Program
{
    /// <summary>
    /// Determines the type of triangle based on side lengths
    /// </summary>
    /// <param name="a">Side 1</param>
    /// <param name="b">Side 2</param>
    /// <param name="c">Side 3</param>
    /// <returns>Type of triangle</returns>
    public static string CheckTriangleType(double a, double b, double c)
    {
        // Check if sides form a valid triangle
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            return "Not a valid triangle";
        }

        if (a == b && b == c)
        {
            return "Equilateral Triangle";
        }
        else if (a == b || b == c || a == c)
        {
            return "Isosceles Triangle";
        }
        else
        {
            return "Scalene Triangle";
        }
    }

    static void Main()
    {
        Console.Write("Enter side 1: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double c = double.Parse(Console.ReadLine());

        string result = CheckTriangleType(a, b, c);

        Console.WriteLine(result);
    }
}
