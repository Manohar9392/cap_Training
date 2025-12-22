using System;

class Program
{
    /// <summary>
    /// Checks whether the given date is valid
    /// </summary>
    /// <param name="day">Day</param>
    /// <param name="month">Month</param>
    /// <param name="year">Year</param>
    /// <returns>true if valid date, false otherwise</returns>
    public static bool IsValidDate(int day, int month, int year)
    {
        // Year check
        if (year <= 0)
            return false;

        // Month check
        if (month < 1 || month > 12)
            return false;

        int daysInMonth;

        // Determine days in month
        if (month == 2)
        {
            // Leap year check
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                daysInMonth = 29;
            else
                daysInMonth = 28;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            daysInMonth = 30;
        }
        else
        {
            daysInMonth = 31;
        }

        // Day check
        if (day < 1 || day > daysInMonth)
            return false;

        return true;
    }

    static void Main()
    {
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (IsValidDate(day, month, year))
        {
            Console.WriteLine("The date is valid.");
        }
        else
        {
            Console.WriteLine("The date is NOT valid.");
        }
    }
}
