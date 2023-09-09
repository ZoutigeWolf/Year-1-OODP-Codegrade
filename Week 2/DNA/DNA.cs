class DNA
{
    public string Seq;

    public DNA(string seq)
    {
        this.Seq = seq;
    }

    public DNA Replicate1() => new DNA(Seq);

    public DNA Replicate2() => this;

    public void Mutate(string seq)
    {
        this.Seq = seq;
    }
}