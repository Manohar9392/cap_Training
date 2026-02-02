using System;
using System.Linq;

public class FlipKey
{
    /// <summary>
    /// Takes a string, filters valid characters, reverses them,
    /// and capitalizes characters at even indices.
    /// </summary>
    public string CleanseAndInvert(string input)
    {
        // Step 1: Validate input
        // Return empty string if input is null or length is less than 6
        if (input == null || input.Length < 6)
        {
            return "";
        }

        // Step 2: Convert input to lowercase
        input = input.ToLower();

        // Step 3: Collect only lowercase alphabets
        // whose ASCII value is odd
        string filteredCharacters = "";

        foreach (char currentChar in input)
        {
            // Check if character is a lowercase alphabet
            if (currentChar >= 'a' && currentChar <= 'z')
            {
                // Check if ASCII value is odd
                if ((int)currentChar % 2 != 0)
                {
                    filteredCharacters += currentChar;
                }
            }
        }

        // Step 4: Reverse the filtered string
        string reversedString = new string(
            filteredCharacters.Reverse().ToArray()
        );

        // Step 5: Convert string to character array
        char[] resultCharacters = reversedString.ToCharArray();

        // Step 6: Capitalize characters at even indices
        for (int index = 0; index < resultCharacters.Length; index++)
        {
            if (index % 2 == 0)
            {
                resultCharacters[index] = char.ToUpper(resultCharacters[index]);
            }
        }

        // Step 7: Convert character array back to string
        return new string(resultCharacters);
    }
}

public class Program
{
    public static void Main()
    {
        FlipKey flipKey = new FlipKey();

        // Test case
        Console.WriteLine(flipKey.CleanseAndInvert("abcdef"));
        Console.ReadLine();
    }
}
