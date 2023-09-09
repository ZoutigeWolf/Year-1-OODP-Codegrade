public static class Library
{
    public static List<Book> Books = new();
    public static List<Customer> Customers = new();

    public static T? FindByID<T>(List<T> items, int id) where T : IHasID => 
        items.Find(i => i.ID == id);
}