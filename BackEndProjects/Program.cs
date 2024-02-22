// See https://aka.ms/new-console-template for more information
using BackEndProjects;
using BackEndProjects.BookManagement;
using BackEndProjects.Calculator;
using BackEndProjects.GuessTheNumber;
using BackEndProjects.Hangman;
using BackEndProjects.StudentManagement;

Console.WriteLine("Hello, World!");


/*Calculator calculator = new Calculator();
calculator.Run();*/

/*GuessTheNumber number = new GuessTheNumber();
number.Run();*/



/*List<string> list = new List<string>();
list.Add("hangman");
list.Add("computer");
list.Add("programming");
list.Add("keyboard");
list.Add("developer");
list.Add("apple");
list.Add("banana");
list.Add("orange");
list.Add("mango");
list.Add("pineapple");



Hangman game = new Hangman(list, 10);
game.Run();*/

/*List<Book> books = new List<Book>
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


BookManager bookManager = new BookManager(books);

UserInterface userInterface = new UserInterface();
userInterface.Run();*/

StudentMenu studentMenu = new StudentMenu();

studentMenu.Run();