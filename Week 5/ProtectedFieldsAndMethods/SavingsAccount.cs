class SavingsAccount : BankAccount
{
    private bool _locked = true;
    
    public SavingsAccount(double balance, double interestRate) : base(balance, interestRate)
    {
    }

    public override double Withdraw(double amount) => _locked ? 0 : base.Withdraw(amount);

    public override void NextYear()
    {
        YearsPassed++;
        
        if (YearsPassed < 5)
            base.NextYear();
        
        else
            _locked = false;
    }
}