namespace GuessTheNumber;

class Program
{
    private static Random _random = new Random(0);

    public static void Main(string[] args)
    {
        if (args.Length != 0 && args[0] != "again")
            Console.WriteLine("Time to play Guess The Number!");

        Console.WriteLine("Give the minimum number:");
        int min = int.Parse(Console.ReadLine() ?? "1");

        Console.WriteLine("Give the maximum number:");
        int max = int.Parse(Console.ReadLine() ?? "2");

        if (max == min)
        {
            Console.WriteLine("The minimum and maximum are equal. Incrementing the maximum by 1.");
            max += 1;
        }

        if (min > max)
        {
            Console.WriteLine("The minimum is higher than the maximum. Switching values.");
            (min, max) = (max, min);
        }

        int number = _random.Next(min, max + 1);

        while (true)
        {
            Console.WriteLine($"Guess the number [{min}-{max}]");
            int guess = int.Parse(Console.ReadLine() ?? "0");

            if (guess == number)
                break;

            Console.WriteLine(guess > number ? "Lower!" : "Higher!");
        }

        Console.WriteLine($"{number} is correct!");

        Console.WriteLine("Do you wish to play another round? Y to continue");
        bool again = (Console.ReadLine() ?? "").ToUpper() == "Y";

        if (again)
        {
            Main(new string[] {"again"});
            return;
        }

        Console.WriteLine("Thank you for playing!");
    }
}