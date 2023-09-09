public class TextDocument : Document
{
    public string Body;
    
    public TextDocument(string title, string body) : base(title)
    {
        this.Body = body;
    }

    public override void Accept(IDocumentVisitor visitor)
    {
        int words = Body.Split('\n').Length;

        Console.WriteLine($"Processing {(words > 10 ? "long" : "short")} document...");
        
        visitor.Visit(this);
    }
}