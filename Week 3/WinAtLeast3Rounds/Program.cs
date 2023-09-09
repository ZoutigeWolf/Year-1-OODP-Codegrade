static class Program
{
    public static void Main(string[] args)
    {
        Game game = new Game(
            new Player("A", 3, 8, 9),
            new Player("B", 9, 3, 9));
        
        Console.WriteLine(game.Round1().Name);
        Console.WriteLine(game.Round2().Name);
        Console.WriteLine(game.Round3().Name);
    }
}