using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie_Theater
{
    public static class TheaterManager
    {
        private static List<MovieScreening> screenings = new List<MovieScreening>();

        // Adds new screening
        public static void AddScreening(string title, DateTime time, string screen, int seats, double price)
        {
            screenings.Add(new MovieScreening(title, time, screen, seats, price));
        }

        // Books tickets if seats are available
        public static bool BookTickets(string movieTitle, DateTime showTime, int tickets)
        {
            var screening = screenings.FirstOrDefault(
                s => s.MovieTitle == movieTitle && s.ShowTime == showTime);

            if (screening == null || screening.AvailableSeats < tickets)
                return false;

            screening.BookedSeats += tickets;
            return true;
        }

        // Groups screenings by movie title
        public static Dictionary<string, List<MovieScreening>> GroupScreeningsByMovie()
        {
            return screenings
                .GroupBy(s => s.MovieTitle)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        // Calculates total revenue
        public static double CalculateTotalRevenue()
        {
            return screenings.Sum(s => s.BookedSeats * s.TicketPrice);
        }

        // Returns screenings with minimum available seats
        public static List<MovieScreening> GetAvailableScreenings(int minSeats)
        {
            return screenings.Where(s => s.AvailableSeats >= minSeats).ToList();
        }
    }
}
