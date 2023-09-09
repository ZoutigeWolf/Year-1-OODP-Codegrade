namespace PayTip;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is the amount to pay?");
        int total = int.Parse(Console.ReadLine() ?? "0");

        int amountPaid = 0;
        while (amountPaid < total)
        {
            Console.WriteLine($"{total - amountPaid} left to pay");

            Console.WriteLine("Pay how much?");
            Console.WriteLine("1: 5\n2: 10\n3: 20\n4: 50");
            string option = Console.ReadLine() ?? "0";

            amountPaid += option switch
            {
                "1" => 5,
                "2" => 10,
                "3" => 20,
                "4" => 50,
                _ => 0
            };
        }

        if (amountPaid > total)
        {
            Console.WriteLine($"You have paid {amountPaid - total} too much. Give a tip? y/n");
            bool giveTip = (Console.ReadLine() ?? "").ToUpper() == "Y";

            if (!giveTip) amountPaid = total;
        }

        Console.WriteLine($"You have paid {amountPaid}");
    }
}