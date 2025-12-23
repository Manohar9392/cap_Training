using System;

class Program
{
    /// <summary>
    /// Prints grade description based on input grade
    /// </summary>
    /// <param name="grade">Grade character (E, V, G, A, F)</param>
    static void PrintGrade(char grade)
    {
        switch (char.ToUpper(grade))
        {
            case 'E':
                Console.WriteLine("Excellent");
                break;

            case 'V':
                Console.WriteLine("Very Good");
                break;

            case 'G':
                Console.WriteLine("Good");
                break;

            case 'A':
                Console.WriteLine("Average");
                break;

            case 'F':
                Console.WriteLine("Fail");
                break;

            default:
                Console.WriteLine("Invalid Grade");
                break;
        }
    }

    static void Main()
    {
        Console.Write("Enter grade (E, V, G, A, F): ");
        char grade = char.Parse(Console.ReadLine());

        PrintGrade(grade);
    }
}
