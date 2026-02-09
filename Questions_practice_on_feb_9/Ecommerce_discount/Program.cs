using Ecommerce_discount;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Policy Type (Festival/Member): ");
        string policyType = Console.ReadLine();
        Console.Write("Enter the Amount: ");
        decimal amount = decimal.TryParse(Console.ReadLine(), out decimal result) ? result : 0;
        switch (policyType.ToLower())
        {
            case "festival":
                FestivalDiscount festivalDiscount = new FestivalDiscount();
                festivalDiscount.GetFinalAmount(amount);
                break;
            case "member":
                MemberDiscount memberDiscount = new MemberDiscount();
                memberDiscount.GetFinalAmount(amount);
                break;
            default:
                Console.WriteLine("Invalid Policy Type");
                break;
        }
    }
}