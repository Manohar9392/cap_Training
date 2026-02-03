using System.Collections.Generic;
using System.Linq;

namespace HotelApp
{
    public static class HotelManager
    {
        public static List<Room> rooms = new List<Room>();

        public static void AddRoom(int number, string type, double price)
        {
            if (rooms.Any(r => r.RoomNumber == number)) return;
            rooms.Add(new Room(number, type, price));
        }

        public static Dictionary<string, List<Room>> GroupRoomsByType()
        {
            return rooms
                .Where(r => r.IsAvailable)
                .GroupBy(r => r.RoomType)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public static bool BookRoom(int roomNumber, int nights)
        {
            var room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber && r.IsAvailable);
            if (room == null) return false;

            room.IsAvailable = false;
            double cost = room.PricePerNight * nights;
            System.Console.WriteLine($"Total Cost: {cost}");
            return true;
        }

        public static List<Room> GetAvailableRoomsByPriceRange(double min, double max)
        {
            return rooms.Where(r => r.IsAvailable && r.PricePerNight >= min && r.PricePerNight <= max).ToList();
        }
    }
}
