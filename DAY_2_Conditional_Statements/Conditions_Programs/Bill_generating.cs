using System;

class Program
{
    /// <summary>
    /// Calculates total electricity bill based on unit slabs
    /// </summary>
    /// <param name="units">Units consumed</param>
    /// <returns>Total bill amount</returns>
    public static double CalculateBill(double units)
    {
        double bill = 0;

        if (units <= 199)
        {
            bill = units * 1.20;
        }
        else if (units <= 400)
        {
            bill = (199 * 1.20) + ((units - 199) * 1.50);
        }
        else if (units <= 600)
        {
            bill = (199 * 1.20) + (201 * 1.50) + ((units - 400) * 1.80);
        }
        else
        {
            bill = (199 * 1.20) + (201 * 1.50) + (200 * 1.80) + ((units - 600) * 2.00);
        }

        // Add surcharge if bill > 400
        if (bill > 400)
        {
            bill += bill * 0.15;
        }

        return bill;
    }

    static void Main()
    {
        Console.Write("Enter number of units consumed: ");
        double units = double.Parse(Console.ReadLine());

        double totalBill = CalculateBill(units);

        Console.WriteLine($"Total Electricity Bill: ₹{totalBill}");
    }
}
