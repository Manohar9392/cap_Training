using System;
using HotelApp;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n=== HOTEL ROOM BOOKING ===");
            Console.WriteLine("1. Add Room");
            Console.WriteLine("2. View Rooms Grouped By Type");
            Console.WriteLine("3. Book Room");
            Console.WriteLine("4. Find Rooms By Price Range");
            Console.WriteLine("0. Exit");
            Console.Write("Choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1: AddRoomMenu(); break;
                case 2: DisplayGroupedRooms(); break;
                case 3: BookRoomMenu(); break;
                case 4: PriceRangeMenu(); break;
            }
        } while (choice != 0);
    }

    static void AddRoomMenu()
    {
        Console.Write("Room Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Room Type: ");
        string type = Console.ReadLine();

        Console.Write("Price Per Night: ");
        double price = double.Parse(Console.ReadLine());

        HotelManager.AddRoom(number, type, price);
        Console.WriteLine("Room added.");
    }

    static void DisplayGroupedRooms()
    {
        var data = HotelManager.GroupRoomsByType();
        foreach (var g in data)
        {
            Console.WriteLine($"\nType: {g.Key}");
            foreach (var r in g.Value)
                Console.WriteLine($"Room {r.RoomNumber} - {r.PricePerNight}");
        }
    }

    static void BookRoomMenu()
    {
        Console.Write("Room Number: ");
        int room = int.Parse(Console.ReadLine());

        Console.Write("Nights: ");
        int nights = int.Parse(Console.ReadLine());

        if (!HotelManager.BookRoom(room, nights))
            Console.WriteLine("Room not available.");
    }

    static void PriceRangeMenu()
    {
        Console.Write("Min Price: ");
        double min = double.Parse(Console.ReadLine());

        Console.Write("Max Price: ");
        double max = double.Parse(Console.ReadLine());

        foreach (var r in HotelManager.GetAvailableRoomsByPriceRange(min, max))
            Console.WriteLine($"Room {r.RoomNumber} - {r.PricePerNight}");
    }
}
