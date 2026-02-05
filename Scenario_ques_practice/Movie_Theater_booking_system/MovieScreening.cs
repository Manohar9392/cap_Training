using System;

namespace Movie_Theater
{
    public class MovieScreening
    {
        public string MovieTitle { get; set; }
        public DateTime ShowTime { get; set; }
        public string ScreenNumber { get; set; }
        public int TotalSeats { get; set; }
        public int BookedSeats { get; set; }
        public double TicketPrice { get; set; }

        public int AvailableSeats => TotalSeats - BookedSeats;

        public MovieScreening(string title, DateTime time, string screen, int seats, double price)
        {
            MovieTitle = title;
            ShowTime = time;
            ScreenNumber = screen;
            TotalSeats = seats;
            TicketPrice = price;
            BookedSeats = 0;
        }
    }
}
