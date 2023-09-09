public class AudioDocument : Document
{
    public int Duration;
    
    public AudioDocument(string title, int duration) : base(title)
    {
        this.Duration = duration;
    }
    
    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}