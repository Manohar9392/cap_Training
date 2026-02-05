using System;
using Movie_Theater;

namespace MovieTheater_App
{
    class Program
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n=== Movie Theater Booking System ===");
                Console.WriteLine("1. Add Screening");
                Console.WriteLine("2. Book Tickets");
                Console.WriteLine("3. View Screenings By Movie");
                Console.WriteLine("4. Available Screenings");
                Console.WriteLine("5. Total Revenue");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        TheaterManager.AddScreening(
                            "Inception",
                            DateTime.Now.AddHours(2),
                            "Screen 1",
                            100,
                            250);
                        Console.WriteLine("Screening Added");
                        break;

                    case 2:
                        bool booked = TheaterManager.BookTickets(
                            "Inception",
                            DateTime.Now.AddHours(2),
                            3);
                        Console.WriteLine(booked ? "Tickets Booked" : "Booking Failed");
                        break;

                    case 3:
                        var grouped = TheaterManager.GroupScreeningsByMovie();
                        foreach (var g in grouped)
                            Console.WriteLine($"{g.Key} : {g.Value.Count} Shows");
                        break;

                    case 4:
                        var available = TheaterManager.GetAvailableScreenings(5);
                        Console.WriteLine($"Available Shows: {available.Count}");
                        break;

                    case 5:
                        Console.WriteLine($"Revenue: ₹{TheaterManager.CalculateTotalRevenue()}");
                        break;
                }
            } while (choice != 0);
        }
    }
}
