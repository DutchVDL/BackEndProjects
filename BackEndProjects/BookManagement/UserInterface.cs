using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.BookManagement
{
    internal class UserInterface
    {
        private BookManager BookManager = new BookManager();
        public void Run()
        {
            Console.WriteLine("Welcome to Book Management System");
            while (true)
            {
                
                Console.WriteLine("Instruction:");
                Console.WriteLine(" press 1 to add a new book");
                Console.WriteLine(" press 2 to see all the books");
                Console.WriteLine(" press 3 to find a new book by it's name");
                Console.WriteLine(" press any other number to exit the program");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid Number! Please follow the given Instructions");
                };
                if (number == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the name of the book:");
                        string name = Console.ReadLine();
                        if (name == null) throw new Exception("Name is Empty");

                        Console.WriteLine("Enter the author of the book:");
                        string author = Console.ReadLine();
                        if (author == null) throw new Exception("Name is Empty");
                     

                        DateTime publicationYear;
                        while (true)
                        {
                            Console.WriteLine("Enter the publication year of the book (YYYY):");
                            if (DateTime.TryParseExact(Console.ReadLine(),"yyyy", null, System.Globalization.DateTimeStyles.None, out publicationYear))
                                break;
                            else
                                Console.WriteLine("Invalid input. Please enter the year in the format YYYY.");
                        }

                        
                        Book newBook = new Book(name, author, publicationYear);
                        BookManager.AddBook(newBook);
                        break;
                    }

                }

                else if (number == 2)
                {
                    BookManager.getAllBooks();
                }

                else if (number ==3 )
                {
                    Console.WriteLine("enter the book's name");
                    string name = Console.ReadLine();
                    if (name == null) throw new Exception("Name is Empty");
                    Console.WriteLine( BookManager.findBook(name));

                }
                else
                {
                    break;
                }

            }









        }
    }
}
