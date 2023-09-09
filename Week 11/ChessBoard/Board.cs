public class Board
{
    public ChessPiece?[,] Pieces = new ChessPiece?[8, 8];

    public void PlacePiece(ChessPiece piece) => Pieces[piece.X, piece.Y] = piece;

    public void MovePiece(ChessPiece piece, int x, int y)
    {
        if (!piece.CanMove(x, y))
        {
            Console.WriteLine(
                $"Invalid move for {(piece.IsWhite ? "White" : "Black")} {piece.GetType()} at ({piece.X}, {piece.Y})");
            
            return;
        }

        Pieces[piece.X, piece.Y] = null;
        Pieces[x, y] = piece;
        piece.X = x;
        piece.Y = y;
    }

    public void Print()
    {
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                ChessPiece? piece = Pieces[y, x];
                
                Console.Write(piece == null ? "  -  " : $" {piece} ");
            }
            
            Console.WriteLine();
        }
    }
}