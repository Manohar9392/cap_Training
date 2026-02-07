using System;
using GymStream;

public class Program
{
    static void Main(string[] args)
    {
        Membership member = new Membership();

        try
        {
            Console.WriteLine("--- GymStream Enrollment Portal ---");

            Console.WriteLine("Enter membership tier (Basic/Premium/Elite):");
            member.Tier = Console.ReadLine();

            Console.WriteLine("Enter duration in months:");
            member.DurationInMonths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter base price per month:");
            member.BasePricePerMonth = Convert.ToDouble(Console.ReadLine());

            // Perform Validation
            if (member.ValidateEnrollment())
            {
                Console.WriteLine("\nEnrollment Successful!");
                double finalBill = member.CalculateTotalBill();
                Console.WriteLine($"Total amount after discount: {finalBill:F2}");
            }
        }
        // Catch Block 1: Custom Exception for Tiers
        catch (InvalidTierException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
        // Catch Block 2: General Exception for Duration or numeric errors
        catch (Exception ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }

        Console.WriteLine("\nPress any key to close...");
        Console.ReadKey();
    }
}

