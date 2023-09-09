public abstract class Document
{
    private static int _lastID = 0;
    
    public int ID;
    public string Title;

    public Document(string title)
    {
        this.Title = title;
        this.ID = _lastID + 1;
        
        _lastID++;
    }

    public abstract void Accept(IDocumentVisitor visitor);
}