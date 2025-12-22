using System;

class Program
{
    /// <summary>
    /// Calculates and displays roots of a quadratic equation
    /// </summary>
    /// <param name="a">Coefficient of x²</param>
    /// <param name="b">Coefficient of x</param>
    /// <param name="c">Constant term</param>
    public static void FindRoots(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("Two distinct real roots:");
            Console.WriteLine($"Root 1 = {root1}");
            Console.WriteLine($"Root 2 = {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("One real and equal root:");
            Console.WriteLine($"Root = {root}");
        }
        else
        {
            Console.WriteLine("No real roots (discriminant is negative).");
        }
    }

    static void Main()
    {
        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic equation (a cannot be 0).");
        }
        else
        {
            FindRoots(a, b, c);
        }
    }
}
