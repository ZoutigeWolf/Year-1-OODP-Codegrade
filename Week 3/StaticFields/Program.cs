static class Program
{
    public static void Main(string[] args)
    {
        BankAccount.InterestRatePercentage = 10.0;

        BankAccount account = new BankAccount();
        account.Deposit(69420.00);
        account.ApplyInterest();
        
        Console.WriteLine($"Balance: {account.Balance}");
    }
}