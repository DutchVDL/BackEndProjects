using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.BookManagement
{
    internal class BookManager
    {
        public static  List<Book> Books {  get; set; }

        public BookManager()
        {
           
        }

        public BookManager(List<Book> books)
        {

            Books = books;
           
        }


        public void AddBook(Book book)
        {
            if (Books.Contains(book)) { throw new Exception("This book already exists");}

            Books.Add(book);
        }

        public Book findBook (string name)
        {
            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    Console.WriteLine(book);
                    return book;
                }
            }

            throw new Exception("Book was not found");
        }

        public void getAllBooks()
        {
            foreach(var book in Books)
            {
                Console.WriteLine(book);
            }

            
        }

    }
}
