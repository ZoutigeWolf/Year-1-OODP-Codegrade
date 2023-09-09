namespace DiceySimulation;
class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        for (int _ = 0; _ < 10; _++)
        {
            Console.WriteLine(random.Next(1, 7));
        }
    }
}