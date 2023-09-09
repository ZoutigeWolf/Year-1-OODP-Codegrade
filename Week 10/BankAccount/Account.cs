public class Account : IEquatable<Account>, IComparable<Account>
{
    public int AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    public bool Equals(Account? other) =>
        other != null &&
        this.AccountNumber == other.AccountNumber &&
        this.AccountHolderName == other.AccountHolderName &&
        this.Balance == other.Balance;


    public override bool Equals(object? other) =>
        other is Account account && Equals(account);

    public int CompareTo(Account? other) =>
        this.AccountNumber.CompareTo(other.AccountNumber);
}