static class Program
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount(69);
        account.Deposit(10);
        
        Console.WriteLine(account.ReadBalance());

        account.Withdraw(100);
        
        Console.WriteLine(account.ReadBalance());
    }
}