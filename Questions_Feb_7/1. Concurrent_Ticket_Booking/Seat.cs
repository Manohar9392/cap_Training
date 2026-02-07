using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Concurrent_Ticket_Booking
{
    public class Seat
    {
        public int SeatNo { get; set; }
        public bool IsBooked { get; set; }
        public string BookedBy { get; set; }
    }
}
