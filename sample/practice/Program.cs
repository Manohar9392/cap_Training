using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Bike
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int PricePerDay { get; set; }
    }

    public class Program
    {
        public static SortedDictionary<int, Bike> bikeDetails =
            new SortedDictionary<int, Bike>();

        // Group bikes by Brand
       public SortedDictionary<string, List<Bike>> GroupByBrand()
{
            SortedDictionary<string, List<Bike>> result =
                new SortedDictionary<string, List<Bike>>();

            foreach (Bike bike in bikeDetails.Values)
            {
                if (!result.ContainsKey(bike.Brand))
                {
                    result[bike.Brand] = new List<Bike>();
                }

                result[bike.Brand].Add(bike);
            }

            return result;
}

        public void AddBikeDetails(string model, string brand, int pricePerDay)
        {
            Bike bike = new Bike
            {
                Model = model,
                Brand = brand,
                PricePerDay = pricePerDay
            };

            bikeDetails.Add(bikeDetails.Count + 1, bike);
        }

        public static void Main()
        {
            Program program = new Program();

            program.AddBikeDetails("Pulsar", "Bajaj", 500);
            program.AddBikeDetails("Activa", "Honda", 300);
            program.AddBikeDetails("FZ", "Yamaha", 400);
            program.AddBikeDetails("Shine", "Honda", 350);

            // Display bikes grouped by brand
            foreach (var brand in program.GroupByBrand())
            {
                Console.WriteLine($"Brand: {brand.Key}");
                foreach (var bike in brand.Value)
                {
                    Console.WriteLine($"  Model: {bike.Model}, Price: {bike.PricePerDay}");
                }
            }
        }
    }
}
