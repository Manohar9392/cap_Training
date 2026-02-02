using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_utility;

namespace Library_management
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }

        /// <summary>
        /// Initializes a new instance of the Book class with the specified title, author, genre, and publication year.
        /// </summary>
        /// <param name="title">The title of the book. Cannot be null or empty.</param>
        /// <param name="author">The author of the book. Cannot be null or empty.</param>
        /// <param name="genre">The genre of the book. Cannot be null or empty.</param>
        /// <param name="year">The year the book was published.</param>

        public Book(string title,string author,string genre,int year)
        {
            Id=BookUtility.books.Count + 1;
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = year;

        }
        


    }
}
