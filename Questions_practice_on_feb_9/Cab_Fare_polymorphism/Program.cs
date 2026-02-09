using Cab_Fare_polymorphism;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the cab type (Mini, Sedan, SUV): ");
        string cabType = Console.ReadLine();
        Console.Write("Enter the distance for the cab fare calculation:");
        int distance=int.TryParse(Console.ReadLine(), out int result) ? result : 0;

        switch (cabType.ToLower())
        {
            case "mini":
                Mini miniCab = new Mini();
                miniCab.CalculateFare(distance);
                break;
            case "sedan":
                Sedan sedanCab = new Sedan();
                sedanCab.CalculateFare(distance);
                break;
            case "suv":
                SUV suvCab = new SUV();
                suvCab.CalculateFare(distance);
                break;
            default:
                Console.WriteLine("Invalid cab type entered.");
                break;
        }
    }
}