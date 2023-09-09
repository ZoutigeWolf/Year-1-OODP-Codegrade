public abstract class ChessPiece
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public bool IsWhite { get; set; }
    
    public abstract string Symbol { get; }

    public ChessPiece(int x, int y, bool isWhite)
    {
        this.X = x;
        this.Y = y;
        this.IsWhite = isWhite;
    }
    
    public override string ToString() => $"{(IsWhite ? "White" : "Black")} {base.ToString()} at ({X}, {Y})";

    public virtual bool CanMove(int x, int y)
    {
        return x > 0 && x < 8 && y > 0 && y < 8;
    }
}