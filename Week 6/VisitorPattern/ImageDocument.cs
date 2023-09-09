public class ImageDocument : Document
{
    public string FilePath;
    
    public ImageDocument(string title, string filePath) : base(title)
    {
        this.FilePath = filePath;
    }
    
    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.Visit(this);
    }
}