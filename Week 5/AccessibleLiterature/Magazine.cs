class Magazine : Publication
{
    public string Issue { get; set; }

    public Magazine(string title, string publisher, string issue, List<string> audience)
        : base(title, publisher, "Magazine", audience)
    {
        this.Issue = issue;
    }

    public override string PublishedOn
    {
        get => PublicationDate == null ? "not published yet" : $"Issue: {Issue}; published on {base.PublishedOn}";
    }
}