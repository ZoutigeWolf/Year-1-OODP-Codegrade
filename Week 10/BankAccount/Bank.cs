using System.Collections;

public class Bank : IEnumerable<Account>
{
    private List<Account> _accounts = new List<Account>();

    public IEnumerator<Account> GetEnumerator()
    {
        foreach (Account account in _accounts)
        {
            yield return account;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(Account account) => _accounts.Add(account);

    public void SortByAccountNumber() => _accounts.Sort();

    public bool ContainsAccount(Account account) =>
        _accounts.Find(a => a.Equals(account)) != null;
}