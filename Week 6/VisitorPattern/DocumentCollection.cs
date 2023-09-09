public class DocumentCollection
{
    private List<Document> _documents = new List<Document>();

    public void AddDocument(Document document) => _documents.Add(document);

    public void RemoveDocument(Document document) => _documents.Remove(document);

    public void DisplayDocuments() => _documents.ForEach(d => 
        Console.WriteLine($"{d.ID}: {d.Title}"));

    public Document? FindDocument(string title) => _documents.Find(d => d.Title == title);
}