public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public int CompareTo(Book? other)
    {
        if (other == null)
        {
            return 1;
        }

        int year = this.Year.CompareTo(other.Year);
        int author = this.Author.CompareTo(other.Author);
        int title = this.Title.CompareTo(other.Author);

        if (year != 0) return year;
        if (author != 0) return author;
        if (title != 0) return title;

        return 0;
    }
}