using System;
using System.Collections.Generic;
using LibrarySystem;   // Import single namespace that contains all logic

class Program
{
    // Entry point of the application
    static void Main()
    {
        // ================= TASK 1 =================
        // Creating Book object
        Book book = new Book
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemID = 101,
            Status = ItemStatus.Borrowed
        };

        // Creating Magazine object
        Magazine magazine = new Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemID = 201
        };

        // Display details and late fee
        book.DisplayItemDetails();
        Console.WriteLine($"Late Fee for 3 days: {book.CalculateLateFee(3)}\n");

        magazine.DisplayItemDetails();
        Console.WriteLine($"Late Fee for 3 days: {magazine.CalculateLateFee(3)}\n");

        // ================= TASK 2 & TASK 4 =================
        // Explicit interface implementation:
        // Methods can ONLY be accessed using interface reference
        IReservable reservable = book;
        INotifiable notifiable = book;

        reservable.ReserveItem();
        notifiable.SendNotification("Your borrowed item is due tomorrow.", UserRole.Member);

        Console.WriteLine();

        // ================= TASK 3 =================
        // Dynamic Polymorphism using parent class reference
        List<LibraryItem> items = new()
        {
            book,
            magazine
        };

        // Runtime decides which DisplayItemDetails() method to call
        foreach (LibraryItem item in items)
        {
            item.DisplayItemDetails();
            Console.WriteLine();
        }

        Console.WriteLine("Method selection happens at runtime.\n");

        // ================= TASK 6 =================
        // Static member shared across entire application
        LibraryAnalytics.TotalBorrowedItems += 5;
        LibraryAnalytics.DisplayAnalytics();
        Console.WriteLine("Static members store system-wide shared data.\n");

        // ================= TASK 7 =================
        // Enum usage
        Console.WriteLine($"User Role: {UserRole.Member}");
        Console.WriteLine($"Item Status: {book.Status}");
        Console.WriteLine("Enums prevent invalid values and improve readability.\n");

        // ================= BONUS TASK =================
        // Creating eBook and calling digital-specific behavior
        EBook ebook = new EBook
        {
            Title = "Digital C#",
            Author = "Alice",
            ItemID = 301
        };

        ebook.Download();
    }
}
