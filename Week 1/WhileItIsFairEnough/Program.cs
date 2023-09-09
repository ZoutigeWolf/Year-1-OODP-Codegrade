namespace WhileItIsFairEnough;

class Program
{
    public static void Main(string[] args)
    {
        int money = 4;

        while (money > 0)
        {
            Console.WriteLine($"Money left: {money}");
            Console.WriteLine("Look around (1) or go in a ride (2)?");
            int choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Yay!");
                    break;

                case 2:
                    Console.WriteLine("Wheee!");
                    money--;
                    break;

                default:
                    break;
            }
        }

        Console.WriteLine("Time to go home");
    }
}