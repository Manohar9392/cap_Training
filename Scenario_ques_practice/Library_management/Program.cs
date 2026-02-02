using System;
using System.Collections.Generic;
using Library_utility;
using Library_management;

namespace Library_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books Grouped By Genre");
                Console.WriteLine("3. Search Books By Author");
                Console.WriteLine("4. Get Total Books Count");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddBookMenu();
                        break;

                    case 2:
                        DisplayBooksByGenre();
                        break;

                    case 3:
                        SearchByAuthor();
                        break;

                    case 4:
                        Console.WriteLine($"Total Books Count: {BookUtility.GetTotalBooksCount()}");
                        break;

                    case 0:
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 0);
        }

        // ===== Menu Methods =====

        static void AddBookMenu()
        {
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter Year Published: ");
            int year = int.Parse(Console.ReadLine());

            BookUtility.AddBook(title, author, genre, year);
            Console.WriteLine("Book added successfully!");
        }

        static void DisplayBooksByGenre()
        {
            var groupedBooks = BookUtility.GroupBooksByGenre();

            if (groupedBooks.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var genre in groupedBooks)
            {
                Console.WriteLine($"\nGenre: {genre.Key}");
                foreach (var book in genre.Value)
                {
                    DisplayBook(book);
                }
            }
        }

        static void SearchByAuthor()
        {
            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            List<Book> books = BookUtility.GetBooksByAuthor(author);

            if (books.Count == 0)
            {
                Console.WriteLine("No books found for this author.");
                return;
            }

            foreach (var book in books)
            {
                DisplayBook(book);
            }
        }

        static void DisplayBook(Book book)
        {
            Console.WriteLine(
                $"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, " +
                $"Genre: {book.Genre}, Year: {book.YearPublished}"
            );
        }
    }
}
