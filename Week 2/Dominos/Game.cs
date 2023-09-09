class Game
{
    public List<DominoPiece> Board = new List<DominoPiece>();

    public void SetDomino(List<DominoPiece> src, int index)
    {
        if (index < 0 || index >= src.Count)
            return;

        DominoPiece piece = src[^(index + 1)];

        if (Board.Count == 0)
        {
            Board.Add(piece);
            return;
        }

        DominoPiece lastPiece = Board[^1];

        if (piece.Pips1 != 0 && piece.Pips1 != lastPiece.Pips2)
            return;
        
        Board.Add(piece);
        lastPiece.Next = piece;
        
        src.RemoveAt(index);
    }

    public void DisplayGame()
    {
        Board.ForEach(piece =>
        {
            string pips1 = piece.Pips1 == 0 ? " " : piece.Pips1.ToString();
            string pips2 = piece.Pips2 == 0 ? " " : piece.Pips2.ToString();
            
            string res = string.Join("\n", new string[5]
            {
                "+---+", 
                $"| {pips1} |", 
                "|   |", 
                $"| {pips2} |", 
                "+---+"
            });
            
            Console.WriteLine(res);
        });
    }
}
