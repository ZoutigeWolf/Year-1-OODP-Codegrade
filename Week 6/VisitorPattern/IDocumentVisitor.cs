public interface IDocumentVisitor
{
    public void Visit(TextDocument textDoc);
    public void Visit(ImageDocument imageDoc);
    public void Visit(AudioDocument audioDoc);
}