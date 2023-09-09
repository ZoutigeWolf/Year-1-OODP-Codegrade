class TextFile : File, IPrintable
{
    public string Contents { get; set; }

    public TextFile(string fileName, string contents) : base($"{fileName}.txt")
    {
        this.Contents = contents;
    }

    public void Print() => Console.WriteLine(Contents);
}