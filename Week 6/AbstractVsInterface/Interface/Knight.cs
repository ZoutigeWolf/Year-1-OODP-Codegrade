namespace AbstractVsInterface.Interface;

public class Knight : IChessPiece
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public bool IsWhite { get; set; }

    public Knight(int x, int y, bool isWhite)
    {
        this.X = x;
        this.Y = y;
        this.IsWhite = isWhite;
    }

    public bool CanMove(int x, int y)
    {
        int dx = this.X - x;
        int dy = this.Y - y;

        return (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
    }

    public override string ToString() =>
        $"{(IsWhite ? "White" : "Black")} Knight at ({X}, {Y})";
}