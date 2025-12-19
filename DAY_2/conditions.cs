using System;

class Conditions
{
    /// <summary>
    /// Check if a number is even
    /// </summary>
    /// <param name="num">Input to check even or odd</param>
    /// <returns>true or false</returns>
    public static bool Iseven(int num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}