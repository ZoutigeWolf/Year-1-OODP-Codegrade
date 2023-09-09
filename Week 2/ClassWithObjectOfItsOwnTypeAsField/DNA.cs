class DNA
{
    private static Random _rand = new Random(0); //Seeded Random

    public DNA? Ancestor;
    public string Seq;

    public DNA(DNA? ancestor, string seq)
    {
        this.Ancestor = ancestor;
        this.Seq = seq;
    }

    public DNA Replicate() => new DNA(this, MutateTransition());
    
    private string MutateTransition()
    {
        int indexToMutate = _rand.Next(0, Seq.Length);
        string mutatedSeq = Seq[0 .. indexToMutate] //Left of mutation
                         + MutateTransitionTable(Seq[indexToMutate]) //Mutation
                         + Seq[(indexToMutate+1) .. Seq.Length]; //Right of mutation
        return mutatedSeq;
    }

    private char MutateTransitionTable(char nucleotide) => char.ToUpper(nucleotide) switch
    {
        'A' => 'G',
        'G' => 'A',
        'C' => 'T',
        'T' => 'C',
        _ => throw new ArgumentOutOfRangeException($"{nucleotide}", $"Unexpected nucleotide value: {nucleotide}"),
    };
}