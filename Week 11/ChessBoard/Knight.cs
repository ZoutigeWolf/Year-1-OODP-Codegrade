public class Knight : ChessPiece
{
    public override string Symbol => (IsWhite ? "W" : "B") + "Kn";
    
    public Knight(int x, int y, bool isWhite) : base(x, y, isWhite)
    {
        
    }

    public override bool CanMove(int x, int y)
    {
        if (!base.CanMove(x, y))
            return false;
        
        int dx = Math.Abs(this.X - x);
        int dy = Math.Abs(this.Y - y);

        return (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
    }
}