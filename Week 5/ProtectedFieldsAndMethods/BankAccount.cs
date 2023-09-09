class BankAccount
{
    protected int YearsPassed = 0;
    protected double InterestRate;
    
    private double _balance;

    public BankAccount(double balance, double interestRate)
    {
        this._balance = balance;
        this.InterestRate = interestRate;
    }

    public double ReadBalance() => _balance;

    public void Deposit(double amount) => _balance += amount > 0 ? amount : 0;

    public virtual double Withdraw(double amount)
    {
        if (SufficientBalance(amount))
        {
            _balance -= amount;
            return amount;
        }

        return 0;
    }

    private bool SufficientBalance(double amount) => amount <= _balance;

    public virtual void NextYear()
    {
        ApplyInterest();
    }

    protected void ApplyInterest() => _balance += (_balance * InterestRate);
}