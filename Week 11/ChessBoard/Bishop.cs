public class Bishop : ChessPiece
{
    public override string Symbol => (IsWhite ? "W" : "B") + "Bi";
    
    public Bishop(int x, int y, bool isWhite) : base(x, y, isWhite)
    {
        
    }

    public override bool CanMove(int x, int y)
    {
        if (!base.CanMove(x, y))
            return false;
        
        int dx = Math.Abs(this.X - x);
        int dy = Math.Abs(this.Y - y);

        return dx == dy;
    }
}