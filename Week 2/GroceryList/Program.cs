static class Program
{
    public static void Main(string[] args)
    {
        ShopItem bread = new ShopItem("0", "Bread", 1.25);
        ShopItem milk = new ShopItem("1", "Milk", 1.35);
        ShopItem frikandelBroodje = new ShopItem("2", "Frikandel Broodje", 0.80);

        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(bread);
        cart.AddItem(milk);
        cart.AddItem(frikandelBroodje);
        cart.AddItem(frikandelBroodje);
        
        Console.WriteLine(cart.Contents());
        Console.WriteLine(cart.TotalPrice());
    }
}