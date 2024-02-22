using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.BookManagement
{
    internal class Book :IComparable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime YearOfPublication { get; set; }

        public Book() { }

        public Book (string name, string author, DateTime yearOfPublication)
        {
            Name = name;
            Author = author;
            YearOfPublication = yearOfPublication;
        }

        public override string ToString()
        {
            return $"Name : {Name}, Author: {Author}, Date of Publication: {YearOfPublication}";
        }

        public int CompareTo(object? obj)
        {
            return Name.CompareTo(obj);
        }
    }
}
