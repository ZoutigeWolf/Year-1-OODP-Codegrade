namespace ForWithMultipleConditions;

class Program
{
    public static void Main(string[] args)
    {
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine($"Enter your PIN\n{i} attempts left");
            string input = Console.ReadLine() ?? "";

            if (input == "1234")
            {
                Console.WriteLine("Correct!");
                return;
            }
        }

        Console.WriteLine("Your pass is confiscated.");
    }
}