class DominoPiece
{
    public int Pips1;
    public int Pips2;

    public DominoPiece? Next = null;

    public DominoPiece(int pips1, int pips2)
    {
        this.Pips1 = pips1;
        this.Pips2 = pips2;
    }
}
