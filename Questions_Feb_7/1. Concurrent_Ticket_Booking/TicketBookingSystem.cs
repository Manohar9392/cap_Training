using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Concurrent_Ticket_Booking
{

    public class TicketBookingSystem
    {
        // Stores all seats (SeatNo → Seat)
        private Dictionary<int, Seat> seats = new Dictionary<int, Seat>();

        // Lock object to synchronize booking
        private readonly object seatLock = new object();

        public TicketBookingSystem(int totalSeats)
        {
            // Initialize seats
            for (int i = 1; i <= totalSeats; i++)
            {
                seats[i] = new Seat
                {
                    SeatNo = i,
                    IsBooked = false
                };
            }
        }

        // Thread-safe seat booking method
        public bool BookSeat(int seatNo, string userId)
        {
            // lock ensures only ONE thread enters this block at a time
            lock (seatLock)
            {
                // Check if seat exists
                if (!seats.ContainsKey(seatNo))
                {
                    return false;
                }

                Seat seat = seats[seatNo];

                // If already booked → return false
                if (seat.IsBooked)
                {
                    return false;
                }

                // Book the seat
                seat.IsBooked = true;
                seat.BookedBy = userId;

                Console.WriteLine($"Seat {seatNo} booked successfully by {userId}");
                return true;
            }
        }
    }
}
