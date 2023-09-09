namespace BookLibraryClasses;

class Library
{
    public int MaxSize;
    public List<Book> Books;

    public Library(int maxSize)
    {
        this.MaxSize = maxSize;
        this.Books = new List<Book>(this.MaxSize);
    }

    public bool AddBook(int id, string title)
    {
        if (Books.Count == Books.Capacity)
            return false;

        Books.Add(new Book(id, title));

        return true;
    }

    public Book? FindBook(int id)
    {
        Book[] results = Books.Where(book => book.ID == id).ToArray();

        return results.Length == 0 ? null : results[0];
    }

    public void ModifyBook(int id, string title)
    {
        Book? book = FindBook(id);

        if (book == null)
            return;

        Books[Books.IndexOf(book)] = new Book(id, title);
    }
}