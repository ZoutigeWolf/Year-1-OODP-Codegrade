namespace FixedDice;
class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random(1);

        for (int _ = 0; _ < 10; _++)
        {
            Console.WriteLine(random.Next(1, 7));
        }
    }
}