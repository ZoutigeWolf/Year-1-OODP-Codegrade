class Library
{
    public List<Book> Books;

    public Library(List<Book> books)
    {
        this.Books = books;
    }

    public Library() : this(new List<Book>())
    {
    }

    public void AddBook(Book book) => Books.Add(book);

    public void AddBook(int id, string title) => AddBook(new Book(id, title));

    public Book? FindBook(int id) => Books.Find(b => b.ID == id);

    public Book? FindBook(string id)
    {
        if (!int.TryParse(id, out int parsedId))
        {
            Console.WriteLine($"ID = {id}: not a valid book ID. Input string was not in a correct format.");
            return null;
        }
            

        return FindBook(parsedId);
    }
}