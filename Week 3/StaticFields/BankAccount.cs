class BankAccount
{
    public static double InterestRatePercentage = 0.0;
    public double Balance = 0.0;

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void ApplyInterest()
    {
        Balance += Balance * (InterestRatePercentage / 100.0);
    }
}