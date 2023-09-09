class Book
{
    public int ID;
    public string Title;

    public Book(int id, string title)
    {
        this.ID = id;
        this.Title = title;
    }

    public Book(int id) : this(id, "Title unknown")
    {
    }

    public string Info() => $"ID = {ID}, Title = {Title}";
}