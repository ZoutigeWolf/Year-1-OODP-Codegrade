namespace ForTheBirthdayRelay;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is the person's name?");
        string name = Console.ReadLine() ?? "";

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(i == 2 ? $"Happy birthday dear {name}!" : "Happy birthday to you!");
        }
    }
}