using Challenge2;

class Program
{
    static void Main(string[] args)
    {
        // create a new book object using the default constructor
        Book book1 = new Book();
        book1.DisplayBookDetails();

        // create a new book object using the parameterized constructor
        Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", 1925, "Charles Scribner's Sons");
        book2.DisplayBookDetails();
        
        // display the total number of books created
        Console.WriteLine($"Total number of books created: {Book.BookCount}");
    }
}