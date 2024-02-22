using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.BookManagement
{
    internal class BookManager
    {
        
            private List<Book> Books = new List<Book>
                    {
                     new Book("To Kill a Mockingbird", "Harper Lee", new DateTime(1960, 7, 11)),
                     new Book("1984", "George Orwell", new DateTime(1949, 6, 8)),
                     new Book("The Great Gatsby", "F. Scott Fitzgerald", new DateTime(1925, 4, 10)),
                     new Book("Pride and Prejudice", "Jane Austen", new DateTime(1813, 1, 28)),
                     new Book("The Catcher in the Rye", "J.D. Salinger", new DateTime(1951, 7, 16)),
                     new Book("To the Lighthouse", "Virginia Woolf", new DateTime(1927, 5, 5)),
                     new Book("Moby-Dick", "Herman Melville", new DateTime(1851, 10, 18)),
                     new Book("Brave New World", "Aldous Huxley", new DateTime(1932, 10, 21)),
                     new Book("The Lord of the Rings", "J.R.R. Tolkien", new DateTime(1954, 7, 29)),
                     new Book("Frankenstein", "Mary Shelley", new DateTime(1818, 1, 1)),
                     new Book("The Picture of Dorian Gray", "Oscar Wilde", new DateTime(1890, 7, 20)),
                     new Book("The Adventures of Huckleberry Finn", "Mark Twain", new DateTime(1884, 12, 10)),
                     new Book("Wuthering Heights", "Emily Brontë", new DateTime(1847, 12, 19)),
                     new Book("The Grapes of Wrath", "John Steinbeck", new DateTime(1939, 4, 14)),
                     new Book("One Hundred Years of Solitude", "Gabriel García Márquez", new DateTime(1967, 5, 30))
                    };


        public BookManager()
        {
           
        }

   


        // Method to add a book to the Books list
        public void AddBook(Book book)
        {
          
            if (Books.Contains(book))
            {
               
                throw new Exception("This book already exists");
            }

          
            Books.Add(book);
        }

        // Method to find a book by its name in the Books list
        public Book FindBook(string name)
        {
         
            foreach (Book book in Books)
            {
             
                if (book.Name == name)
                {
                    
                    return book;
                }
            }

           
            throw new Exception("Book was not found");
        }

        // Method to print details of all books in the Books list
        public void GetAllBooks()
        {
          
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }

    }
}
