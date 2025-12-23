using System;

class Program
{
    /// <summary>
    /// Determines the quadrant of a point (x, y)
    /// </summary>
    /// <param name="x">X-coordinate</param>
    /// <param name="y">Y-coordinate</param>
    /// <returns>Quadrant or axis information</returns>
    public static string FindQuadrant(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            return "Point lies in First Quadrant";
        }
        else if (x < 0 && y > 0)
        {
            return "Point lies in Second Quadrant";
        }
        else if (x < 0 && y < 0)
        {
            return "Point lies in Third Quadrant";
        }
        else if (x > 0 && y < 0)
        {
            return "Point lies in Fourth Quadrant";
        }
        else if (x == 0 && y == 0)
        {
            return "Point lies at the Origin";
        }
        else if (x == 0)
        {
            return "Point lies on Y-axis";
        }
        else // y == 0
        {
            return "Point lies on X-axis";
        }
    }

    public static void Main()
    {
        Console.Write("Enter x coordinate: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter y coordinate: ");
        int y = int.Parse(Console.ReadLine());

        string result = FindQuadrant(x, y);

        Console.WriteLine(result);
    }
}
