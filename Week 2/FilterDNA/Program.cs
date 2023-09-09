static class Program
{
    public static void Main(string[] args)
    {
        List<DNA> dnaList = new List<DNA>()
        {
            new DNA("ACGT"),
            new DNA("GCTTAC"),
            new DNA("CGTTAGCTT"),
            new DNA("TACA"),
        };
        
        Console.WriteLine("What is the minimum sequence length?");
        int len = int.Parse(Console.ReadLine() ?? "0");

        List<DNA> res = dnaList.Where(x => x.Seq.Length >= len).ToList();
        
        Console.WriteLine("The filtered list:");
        
        res.ForEach(x => Console.WriteLine(x.Seq));
    }
}