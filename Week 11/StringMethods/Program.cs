public class Program
{
    public static void Main()
    {
        (string user, string domain, string topLevelDomain) res = EmailParser.ParseEmail("nick.gur@pornhub.com");
        
        Console.WriteLine(res.user);
        Console.WriteLine(res.domain);
        Console.WriteLine(res.topLevelDomain);
        
        res = EmailParser.ParseEmail("ballen@likkerballen.a");
        
        Console.WriteLine(res.user);
        Console.WriteLine(res.domain);
        Console.WriteLine(res.topLevelDomain);
    }
}