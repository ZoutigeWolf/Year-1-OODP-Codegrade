static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GameTools.CoinFlip(10));
        GameTools.ReturnCount = false;
        Console.WriteLine(GameTools.CoinFlip(10));

        GameTools.ReturnCount = true;
        Console.WriteLine(GameTools.DiceRoll(6, 10));
        GameTools.ReturnCount = false;
        Console.WriteLine(GameTools.DiceRoll(6, 10));
    }
}