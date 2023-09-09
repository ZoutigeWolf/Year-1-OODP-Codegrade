namespace TaxTask;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your balance?");
        double balance = double.Parse(Console.ReadLine() ?? "1");

        Console.WriteLine("What is the interest rate?");
        double interestRate = double.Parse(Console.ReadLine() ?? "1");

        Console.WriteLine("How many years?");
        int years = int.Parse(Console.ReadLine() ?? "1");

        double totalTaxPaid = 0;

        for (int i = 0; i < years; i++)
        {
            balance += balance * (interestRate / 100);

            double tax = CalculateTax(balance);
            balance -= tax;
            totalTaxPaid += tax;
        }

        Console.WriteLine($"Balance after {years} years: {(int)balance}");
        Console.WriteLine($"Amount of taxes paid: {(int)totalTaxPaid}");
    }

    static double CalculateTax(double balance)
    {
        balance -= 50000;

        if (balance <= 0) return 0;

        double totalTax = (balance <= 50000 ? balance : 50000) * 0.015;

        balance -= 50000;

        if (balance > 0) totalTax += balance * 0.03;

        return totalTax;
    }
}