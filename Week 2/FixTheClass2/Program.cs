namespace FixTheClass2;
public class Program
{
    public static void Main()
    {
        PlayingCard card = new PlayingCard("Spades", "Ace");
        Console.WriteLine(card.Description());
    }
}