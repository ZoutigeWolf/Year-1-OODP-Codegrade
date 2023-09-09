using System.Text;

public static class DnaStrand
{
    public static string ComplementaryStrand(string strand)
    {
        StringBuilder compStrand = new StringBuilder();

        foreach (char c in strand.Reverse())
        {
            compStrand.Append(c switch
            {
                'A' => 'T',
                'C' => 'G',
                'G' => 'C',
                'T' => 'A',
            });
        }

        return compStrand.ToString();
    }

    public static bool IsValidDnaStrand(string strand)
    {
        strand = strand.Replace("A", null);
        strand = strand.Replace("C", null);
        strand = strand.Replace("G", null);
        strand = strand.Replace("T", null);

        return strand.Length == 0;
    }

    public static string Transcribe(string strand) => strand.Replace("T", "U");

    public static int HammingDistance(string a, string b)
    {
        if (a.Length != b.Length)
            return -1;

        return a.Where((c, i) => c != b[i]).Count();
    }
}