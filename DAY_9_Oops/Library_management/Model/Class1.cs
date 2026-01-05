using System;

namespace LibrarySystem
{
    // ================= ENUMS =================
    // Enum restricts values to predefined constants
    public enum UserRole
    {
        Admin,
        Librarian,
        Member
    }

    public enum ItemStatus
    {
        Available,
        Borrowed,
        Reserved,
        Lost
    }

    // ================= INTERFACES =================
    // Interface for reservable behavior
    public interface IReservable
    {
        void ReserveItem();
    }

    // Interface for notification behavior
    public interface INotifiable
    {
        void SendNotification(string message, UserRole role);
    }

    // ================= ABSTRACT CLASS =================
    // Base class for all library items
    public abstract class LibraryItem
    {
        // Common properties for all items
        public string Title { get; set; }
        public string Author { get; set; }
        public int ItemID { get; set; }
        public ItemStatus Status { get; set; }

        // Abstract methods must be implemented by child classes
        public abstract void DisplayItemDetails();
        public abstract double CalculateLateFee(int days);
    }

    // ================= BOOK CLASS =================
    // Inherits abstract class and implements multiple interfaces
    public class Book : LibraryItem, IReservable, INotifiable
    {
        // Override abstract method
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: Book");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        // Book late fee = 1 unit per day
        public override double CalculateLateFee(int days)
        {
            return days * 1.0;
        }

        // Explicit interface implementation
        // These methods CANNOT be called using Book object directly
        void IReservable.ReserveItem()
        {
            Console.WriteLine("Book reserved successfully.");
        }

        void INotifiable.SendNotification(string message, UserRole role)
        {
            // Role-based notification logic (BONUS)
            if (role == UserRole.Admin)
                Console.WriteLine($"Admin Alert: {message}");
            else
                Console.WriteLine($"Member Notification: {message}");
        }
    }

    // ================= MAGAZINE CLASS =================
    public class Magazine : LibraryItem
    {
        // Override abstract method
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: Magazine");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        // Magazine late fee = 0.5 unit per day
        public override double CalculateLateFee(int days)
        {
            return days * 0.5;
        }
    }

    // ================= BONUS: EBOOK =================
    // New item type extending existing system
    public class EBook : LibraryItem
    {
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: eBook");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        // No late fee for digital items
        public override double CalculateLateFee(int days)
        {
            return 0;
        }

        // Digital-specific behavior
        public void Download()
        {
            Console.WriteLine("eBook downloaded successfully.");
        }
    }

    // ================= PARTIAL & STATIC CLASS =================
    // Static class stores system-wide data
    public static partial class LibraryAnalytics
    {
        public static int TotalBorrowedItems { get; set; }
    }

    // Second part of partial class
    public static partial class LibraryAnalytics
    {
        public static void DisplayAnalytics()
        {
            Console.WriteLine($"Total Items Borrowed: {TotalBorrowedItems}");
        }
    }
}
