public static class EmailParser
{
    public static (string recipient, string domain, string topLevelDomain) ParseEmail(string address)
    {
        try
        {
            string[] parts = address.Trim().Split('@');

            string user = parts[0];
            string domain = parts[1];
            string topLevelDomain = parts[1].Split('.')[1];

            return (user, domain, topLevelDomain);
        }
        catch
        {
            return (null, null, null)!;
        }
    }
}