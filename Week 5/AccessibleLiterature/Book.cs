class Book : Publication
{
    public string ISBN { get; set; }
    public string Currency { get; set; }
    public double Price { get; set; }
    public string Author { get; set; }

    public Book(string isbn, string title, string author, string publisher, List<string> audience) : base(title, publisher, "Book", audience)
    {
        this.ISBN = isbn;
        this.Author = author;
    }
    
    public bool IsSuitableForChild() => Audience.Contains("Children");

    public void SetPrice(double price, string currency)
    {
        if (price <= 0)
            return;

        Price = price;
        Currency = currency;
    }

    public override string ToString() =>
        $"{Author}, ISBN: {ISBN}, {Title}, {Pages} {(Pages == 1 ? "page" : "pages")}, {PublishedOn}, {Currency} {Price}";
}