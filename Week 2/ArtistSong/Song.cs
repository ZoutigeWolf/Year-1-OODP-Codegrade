class Song
{
    public string Title;
    public Artist Singer;

    public Song(string title)
    {
        this.Title = title;
        this.Singer = new Artist("Unknown");
    }

    public void SetSinger(Artist artist)
    {
        Singer = artist;
    }

    public string Info() => $"{Title} is by {Singer.Name}";
}