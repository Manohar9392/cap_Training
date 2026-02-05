using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental
{
    public static class RentalManager
    {
        private static List<RentalCar> cars = new List<RentalCar>();
        private static List<Rental> rentals = new List<Rental>();
        private static int rentalIdCounter = 1;

        public static void AddCar(string license, string make, string model, string type, double rate)
        {
            cars.Add(new RentalCar
            {
                LicensePlate = license,
                Make = make,
                Model = model,
                CarType = type,
                DailyRate = rate
            });
        }

        public static bool RentCar(string license, string customer, DateTime start, int days)
        {
            var car = cars.FirstOrDefault(c => c.LicensePlate == license && c.IsAvailable);
            if (car == null) return false;

            car.IsAvailable = false;

            rentals.Add(new Rental
            {
                RentalId = rentalIdCounter++,
                LicensePlate = license,
                CustomerName = customer,
                StartDate = start,
                EndDate = start.AddDays(days),
                TotalCost = days * car.DailyRate
            });

            return true;
        }

        public static Dictionary<string, List<RentalCar>> GroupCarsByType()
        {
            return cars.Where(c => c.IsAvailable)
                       .GroupBy(c => c.CarType)
                       .ToDictionary(g => g.Key, g => g.ToList());
        }

        public static List<Rental> GetActiveRentals()
        {
            return rentals.Where(r => r.EndDate >= DateTime.Now).ToList();
        }

        public static double CalculateTotalRentalRevenue()
        {
            return rentals.Sum(r => r.TotalCost);
        }
    }
}
