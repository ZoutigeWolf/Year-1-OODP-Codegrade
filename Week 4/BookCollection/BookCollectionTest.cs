using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookCollection.Tests;

[TestClass]
public class BookCollectionTest
{
    [TestInitialize]
    public void RemoveAllBooks()
    {
        Program.Books.Clear();
    }

    [TestMethod]
    public void Add_Book()
    {
        Assert.IsTrue(Program.Books.Count == 0);

        Program.Books.Add(new Book("A", "B", 0));

        Assert.IsTrue(Program.Books.Count == 1);
    }

    [TestMethod]
    public void Remove_Book()
    {
        Book book = new Book("A", "B", 0);
        
        Program.Books.Add(book);
        Program.Books.Remove(book);

        Assert.IsTrue(Program.Books.Count == 0);
    }

    [TestMethod]
    public void Remove_AllBooks()
    {
        Program.Books.Clear();

        Assert.IsTrue(Program.Books.Count == 0);
    }

    [TestMethod]
    public void Get_Books()
    {
        Program.Books.Add(new Book("1", "1", 1));
        Program.Books.Add(new Book("1", "1", 1));
        Program.Books.Add(new Book("1", "1", 1));

        Assert.IsTrue(Program.Books.Count == 3);
    }

    [TestMethod]
    public void Get_Book()
    {
        Book book1 = new Book("1", "1", 1);
        Book book2 = new Book("2", "2", 2);
        Book book3 = new Book("3", "3", 3);
        
        Program.Books.Add(book1);
        Program.Books.Add(book2);
        Program.Books.Add(book3);

        Assert.AreEqual(Program.Books[0].Title, "1");
        Assert.AreEqual(Program.Books[1].Title, "2");
    }

    [TestMethod]
    public void Set_Books()
    {
        List<Book> books = new List<Book>();
        
        Book book1 = new Book("1", "1", 1);
        Book book2 = new Book("2", "2", 2);
        Book book3 = new Book("3", "3", 3);
        
        books.Add(book1);
        books.Add(book2);
        books.Add(book3);

        
        books.ForEach(b => Program.Books.Add(b));

        Assert.IsTrue(Program.Books.Count == 3);  

        Assert.AreEqual(Program.Books[0].Title, "1");
        Assert.AreEqual(Program.Books[1].Title, "2");
    }
}