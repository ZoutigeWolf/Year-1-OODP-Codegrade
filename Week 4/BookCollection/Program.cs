using Newtonsoft.Json;

namespace BookCollection;

static class Program
{
    public static List<Book> Books = LoadBooks("books.json");
    
    public static void Main(string[] args)
    {
        PrintBooks();
        
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("+: add a new book");
        Console.WriteLine("-: remove a book");
        Console.WriteLine("A number: see information on this book");
        Console.WriteLine("q: quit");
        
        Console.Write(">");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int index))
        {
            ProcessBookInformation(index);
        }
        else if (input == "q")
        {
            return;
        }
        else
        {
            Action handler = input switch
            {
                "+" => ProcessAddBook,
                "-" => ProcessRemoveBook,
                _ => () => Console.WriteLine("Invalid choice.")
            };

            handler();
            SaveBooks(Books, "books.json");
        }
        
        Main(args);
    }

    public static void ProcessAddBook()
    {
        Console.WriteLine("Enter the title of the new book:");
        string title = Console.ReadLine() ?? "";
        
        Console.WriteLine("Enter the author of the new book:");
        string author = Console.ReadLine() ?? "";
        
        Console.WriteLine("Enter the publication year of the new book:");
        string year = Console.ReadLine() ?? "";

        if (!int.TryParse(year, out int publicationYear))
        {
            Console.WriteLine("Year is not in a valid format.");
            return;
        }
        
        Books.Add(new Book(title, author, publicationYear));
    }
    
    public static void ProcessRemoveBook()
    {
        Console.WriteLine("Enter the number of the book to remove:");
        string input = Console.ReadLine() ?? "";

        if (!int.TryParse(input, out int index))
        {
            Console.WriteLine("Not an index.");
            return;
        }

        if (index < 1 || index > Books.Count)
        {
            Console.WriteLine("Book does not exist.");
            return;
        }
        
        Books.RemoveAt(index - 1);
        Console.WriteLine("Book removed.");
    }
    
    public static void ProcessBookInformation(int index)
    {
        if (index < 1 || index > Books.Count)
        {
            Console.WriteLine("Book does not exist.");
            return;
        }

        Book book = Books[index - 1];
        
        Console.WriteLine($"Title: {book.Title}");
        Console.WriteLine($"Author: {book.Author}");
        Console.WriteLine($"Publication Year: {book.PublicationYear}");
    }

    public static void PrintBooks()
    {
        Console.WriteLine("\nBook Collection:");
        for (int i = 0; i < Books.Count; i++)
        {
            Book book = Books[i];
            Console.WriteLine($"{i + 1}. {book.Title} by {book.Author} ({book.PublicationYear})");
        }
    }

    public static List<Book> LoadBooks(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                return JsonConvert.DeserializeObject<List<Book>>(reader.ReadToEnd());
            }
            
        }
        catch (Exception e)
        {
            if (e is FileNotFoundException)
            {
                Console.WriteLine($"Missing JSON file. {e.Message}");
            }
            else if (e is JsonReaderException)
            {
                Console.WriteLine($"Invalid JSON. {e.Message}");
            }

            return new List<Book>();
        }
    }

    public static void SaveBooks(List<Book> books, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(JsonConvert.SerializeObject(books));
            }
            
        }
        catch (Exception e)
        {
            if (e is FileNotFoundException)
            {
                Console.WriteLine($"Missing JSON file. {e.Message}");
            }
            else if (e is JsonWriterException)
            {
                Console.WriteLine($"Invalid JSON. {e.Message}");
            }
        }
    }
}