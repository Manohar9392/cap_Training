using System;
using upi;
public class Program
{
    /// <summary>
    /// Main method - Entry point of the program.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(String[] args)
    {
        UpiPayment upiPayment = new UpiPayment(1500.00m, "user@upi");
        upiPayment.pay();
        upiPayment.Receipt();
    }
}