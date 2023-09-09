namespace BookLibraryClasses;

class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library(10);
        library.AddBook(0, "Balls");
    }
}