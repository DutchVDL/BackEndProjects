using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.BookManagement
{
    internal class Book : IComparable
    {
        // Properties
        public string Name { get; set; }  // Name of the book
        public string Author { get; set; }  // Author of the book
        public DateTime YearOfPublication { get; set; }  // Year of publication of the book

        // Constructors
        public Book() { }  // Default constructor

        // Constructor with parameters
        public Book(string name, string author, DateTime yearOfPublication)
        {
            Name = name;
            Author = author;
            YearOfPublication = yearOfPublication;
        }

        // ToString method override to provide a string representation of the book
        public override string ToString()
        {
            // Return a formatted string including the name, author, and year of publication
            return $"Name: {Name}, Author: {Author}, Year of Publication: {YearOfPublication.Year}";
        }

        // CompareTo method implementation for IComparable interface
        public int CompareTo(object? obj)
        {
            // Check if the object is null
            if (obj == null) return 1;

            // If the object is a Book, compare their names
            if (obj is Book otherBook)
            {
                return this.Name.CompareTo(otherBook.Name);
            }
            else
            {
                // Throw an exception if the object is not a Book
                throw new ArgumentException("Object is not a Book");
            }
        }
    }
}
