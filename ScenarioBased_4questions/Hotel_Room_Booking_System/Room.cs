namespace HotelApp
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int number, string type, double price)
        {
            RoomNumber = number;
            RoomType = type;
            PricePerNight = price;
            IsAvailable = true;
        }
    }
}
