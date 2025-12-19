using System;



class Practice_questions
{
    /// <summary>
    /// Classify height into categories
    /// </summary>
    /// <param name="height">input in cm to check height categories</param>
    /// <returns>height category based on input</returns>
    public static string Height_classifier(double height)
    {
        if (height < 150)
        {
            return "Dwarf";
        }
        else if (height < 165)
        {
            return "Average";
        }
        else if (height < 190)
        {
            return "Tall";
        }
        else
        {
            return "Abnormal";
        }
    }

    /// <summary>
    /// Find maximum of three numbers
    /// </summary>
    /// <param name="num1">First Number</param>
    /// <param name="num2">Second Number</param>
    /// <param name="num3">Third Number</param>
    /// <returns>Maximum of three numbers</returns>

    public static int Max_of_three(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            return num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }

/// <summary>
/// Check if a year is leap year or not
/// </summary>
/// <param name="year">Input to check Laep year or not</param>
/// <returns> true or false</returns>
    public static bool IsLeapYear(int year)
    {
        if(year %400 ==0 ||(year %4==0 && year % 100 != 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    

}