using System;
using Global_cargo_solutions;
public class Program
{
    public static void Main(string[] args)
    {
        ShipmentDetails shipmentDetails;
        while (true)
        {
            Console.Write("Enter shipment code:");
            string code = Console.ReadLine();
            if (ShipmentDetails.ValidateShipmentCode(code))
            {
                Console.Write("Enter weight in kgs:");
                double weight = double.Parse(Console.ReadLine());
                Console.Write("Enter mode of transportation (Air/Sea/Land):");
                string mode = Console.ReadLine();
                Console.Write("Enter number of days for delivery:");
                int days = Convert.ToInt32(Console.ReadLine());
                shipmentDetails = new ShipmentDetails(code,mode,weight,days);

            }
            else
            {
                Console.WriteLine("Invalid shipment code. Please try again.");
                break;
            }
        }
    }
}