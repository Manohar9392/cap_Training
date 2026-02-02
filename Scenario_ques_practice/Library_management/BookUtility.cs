using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_management;

namespace Library_utility
{
    public static class BookUtility
    {

        public static List<Book> books = new List<Book>();

        /// <summary>
        /// Adds a new book to the collection with the specified title, author, genre, and publication year.
        /// </summary>
        /// <param name="title">The title of the book to add. Cannot be null or empty.</param>
        /// <param name="author">The author of the book to add. Cannot be null or empty.</param>
        /// <param name="genre">The genre of the book to add. Cannot be null or empty.</param>
        /// <param name="year">The year the book was published.</param>


        public static void AddBook(string title, string author, string genre, int year)
        {
            Book newBook = new Book(title, author, genre, year);
            books.Add(newBook);

        }
        /// <summary>
        /// This method groups books by their genre and returns a sorted dictionary
        /// </summary>
        /// <returns>SortedDictionary<string, List<Book>></returns>

        public static SortedDictionary<string, List<Book>> GroupBooksByGenre()
        {
            SortedDictionary<string, List<Book>> genreDictionary = new SortedDictionary<string, List<Book>>();
            foreach(var book in books)
            {
                if(!genreDictionary.ContainsKey(book.Genre))
                {
                    genreDictionary[book.Genre] = new List<Book>();
                }
                genreDictionary[book.Genre].Add(book);
            }
            return genreDictionary;

        }

        /// <summary>
        /// Retrieves a list of books written by the specified author.
        /// </summary>
        /// <param name="author">The name of the author whose books to retrieve. Cannot be null.</param>
        /// <returns>A list of <see cref="Book"/> objects authored by the specified author. The list is empty if no books by the
        /// author are found.</returns>

        public static List<Book> GetBooksByAuthor(string author)
        {
            List<Book> authorBooks = new List<Book>();
            foreach(var book in books)
            {
                if(book.Author==author)
                {
                    authorBooks.Add(book);
                }
            }

            return authorBooks;

        }


        /// <summary>
        /// Gets the total number of books currently in the collection.
        /// </summary>
        /// <returns>The number of books in the collection.</returns>

        public static int GetTotalBooksCount()
        {

            return books.Count;
        }



    }
    
}
