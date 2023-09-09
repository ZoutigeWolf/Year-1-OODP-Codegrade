class Publication
{
    private int _pages;

    public int Pages
    {
        get => _pages;
        set => _pages = value > 0 ? value : _pages;
    }
    
    private DateTime? _datePublished = null;

    public DateTime? PublicationDate
    {
        get => _datePublished;
        set => _datePublished = value;
    }

    protected List<string> Audience { get; set; }
    
    protected bool IsPublished { get; set; }
    
    public string Publisher { get; set; }
    public string Title { get; set; }
    public string PublicationType { get; set; }

    public Publication(string title, string publisher, string publicationType, List<string> audience)
    {
        this.Title = title;
        this.Publisher = publisher;
        this.PublicationType = publicationType;
        this.Audience = audience;
    }

    public virtual string PublishedOn
    {
        get => PublicationDate == null ? "Not published yet" : PublicationDate?.ToString("d");
    }

    public bool IsSuitableForAudience(string audience) => Audience.Contains(audience);

    public override string ToString() => $"{Title}, {Pages} {(Pages == 1 ? "page" : "pages")}, {PublishedOn}";
}  