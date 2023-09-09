class BankAccount
{
    private double _balance;

    public BankAccount(double balance)
    {
        this._balance = balance;
    }

    public double ReadBalance() => _balance;

    public void Deposit(double amount) => _balance += amount > 0 ? amount : 0;

    public double Withdraw(double amount) => SufficientBalance(amount) ? _balance -= amount : 0;

    private bool SufficientBalance(double amount) => amount <= _balance;
}