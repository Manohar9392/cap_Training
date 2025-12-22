using System;

class Program
{
    /// <summary>
    /// Checks whether the given character is a vowel
    /// </summary>
    /// <param name="ch">Input character</param>
    /// <returns>true if vowel, false otherwise</returns>
    public static bool IsVowel(char ch)
    {
        switch (char.ToLower(ch))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;

            default:
                return false;
        }
    }

    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = char.Parse(Console.ReadLine());

        if (IsVowel(ch))
        {
            Console.WriteLine("The character is a vowel.");
        }
        else
        {
            Console.WriteLine("The character is not a vowel.");
        }
    }
}
