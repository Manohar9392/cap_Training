using System;

class Program
{
    /// <summary>
    /// Calculates and prints profit or loss percentage
    /// </summary>
    /// <param name="costPrice">Cost Price</param>
    /// <param name="sellingPrice">Selling Price</param>
    public static void CalculateProfitLoss(double costPrice, double sellingPrice)
    {
        if (sellingPrice > costPrice)
        {
            double profit = sellingPrice - costPrice;
            double profitPercentage = (profit / costPrice) * 100;
            Console.WriteLine($"Profit = ₹{profit}");
            Console.WriteLine($"Profit Percentage = {profitPercentage:F2}%");
        }
        else if (sellingPrice < costPrice)
        {
            double loss = costPrice - sellingPrice;
            double lossPercentage = (loss / costPrice) * 100;
            Console.WriteLine($"Loss = ₹{loss}");
            Console.WriteLine($"Loss Percentage = {lossPercentage:F2}%");
        }
        else
        {
            Console.WriteLine("No profit, no loss.");
        }
    }

    static void Main()
    {
        Console.Write("Enter Cost Price: ");
        double cp = double.Parse(Console.ReadLine());

        Console.Write("Enter Selling Price: ");
        double sp = double.Parse(Console.ReadLine());

        CalculateProfitLoss(cp, sp);
    }
}
