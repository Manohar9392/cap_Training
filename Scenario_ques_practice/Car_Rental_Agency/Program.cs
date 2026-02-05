using System;
using Car_Rental;

namespace CarRental_App
{
    class Program
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n=== Car Rental System ===");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Rent Car");
                Console.WriteLine("3. View Cars By Type");
                Console.WriteLine("4. View Active Rentals");
                Console.WriteLine("5. Total Revenue");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.Write("License Plate: ");
                        string license = Console.ReadLine();

                        Console.Write("Make: ");
                        string make = Console.ReadLine();

                        Console.Write("Model: ");
                        string model = Console.ReadLine();

                        Console.Write("Type: ");
                        string type = Console.ReadLine();

                        Console.Write("Daily Rate: ");
                        double rate = double.Parse(Console.ReadLine());

                        RentalManager.AddCar(license, make, model, type, rate);
                        Console.WriteLine("Car Added");
                        break;

                    case 2:
                        Console.Write("License Plate: ");
                        string lic = Console.ReadLine();

                        Console.Write("Customer Name: ");
                        string customer = Console.ReadLine();

                        Console.Write("Days: ");
                        int days = int.Parse(Console.ReadLine());

                        Console.WriteLine(
                            RentalManager.RentCar(lic, customer, DateTime.Now, days)
                            ? "Car Rented"
                            : "Car Not Available");
                        break;

                    case 3:
                        var cars = RentalManager.GroupCarsByType();
                        foreach (var c in cars)
                            Console.WriteLine($"{c.Key} → {c.Value.Count} cars");
                        break;

                    case 4:
                        foreach (var r in RentalManager.GetActiveRentals())
                            Console.WriteLine($"{r.CustomerName} → {r.LicensePlate}");
                        break;

                    case 5:
                        Console.WriteLine($"Revenue: ₹{RentalManager.CalculateTotalRentalRevenue()}");
                        break;
                }

            } while (choice != 0);
        }
    }
}
