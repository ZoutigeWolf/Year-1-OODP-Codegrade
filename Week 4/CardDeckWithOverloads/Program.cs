static class Program
{
    public static void Main(string[] args)
    {
        Deck deck = new Deck(true);

        deck.Cards.ForEach(c => Console.WriteLine(c.GetName()));
    }
}