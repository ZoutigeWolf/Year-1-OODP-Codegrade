class Artist
{
    public string Name;
    public int NumberOfSongs = 0;

    public Song WriteSong(string name)
    {
        NumberOfSongs++;
        var song = new Song(name);
        song.SetSinger(this);
        return song;
    }
    
    public Artist(string name) => Name = name;
}