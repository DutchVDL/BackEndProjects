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
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime YearOfPublication { get; set; }

        // Constructors
        public Book() { }

        // Constructor with parameters
        public Book(string name, string author, DateTime yearOfPublication)
        {
            Name = name;
            Author = author;
            YearOfPublication = yearOfPublication;
        }


        public override string ToString()
        {

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
