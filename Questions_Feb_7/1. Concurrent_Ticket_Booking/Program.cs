using System;

using _1._Concurrent_Ticket_Booking;

class Program
{
    static void Main()
    {
        TicketBookingSystem system = new TicketBookingSystem(10);

        system.BookSeat(1, "UserA");
        system.BookSeat(1, "UserB"); // Will return false
    }
}