public class Program
{
    public static int[][][] WinPatterns = new int[][][]
    {
        // Rows
        new int[][] { new int[] {0, 0}, new int[] {0, 1}, new int[] {0, 2} },
        new int[][] { new int[] {1, 0}, new int[] {1, 1}, new int[] {1, 2} },
        new int[][] { new int[] {2, 0}, new int[] {2, 1}, new int[] {2, 2} },

        // Columns
        new int[][] { new int[] {0, 0}, new int[] {1, 0}, new int[] {2, 0} },
        new int[][] { new int[] {0, 1}, new int[] {1, 1}, new int[] {2, 1} },
        new int[][] { new int[] {0, 2}, new int[] {1, 2}, new int[] {2, 2} },

        // Diagonals
        new int[][] { new int[] {0, 0}, new int[] {1, 1}, new int[] {2, 2} },
        new int[][] { new int[] {0, 2}, new int[] {1, 1}, new int[] {2, 0} }
    };
    
    
    public static char[,] Board = new char[3,3]
    {
        {' ', ' ', ' '},
        {' ', ' ', ' '},
        {' ', ' ', ' '},
    };

    public static bool IsXTurn = true;
    
    public static void Main()
    {
        DisplayBoard();

        (bool gameEnded, char winner) res = CheckWin();

        if (res.gameEnded)
        {
            Console.WriteLine(res.winner == ' ' ? "It's a tie!" : $"{res.winner} wins!");
            
            return;
        }
        
        Console.Write($"\nPlayer {(IsXTurn ? 'X' : 'O')}, please enter your move (row, column): ");

        string[] pos = (Console.ReadLine() ?? "").Split(',');

        if (pos[0] == "q")
            return;
        
        int x = int.Parse(pos[0]) - 1;
        int y = int.Parse(pos[1]) - 1;

        Board[x, y] = IsXTurn ? 'X' : 'O';

        IsXTurn = !IsXTurn;
        
        Main();
    }

    public static void DisplayBoard()
    {
        Console.WriteLine($" {Board[0, 0]} | {Board[0, 1]} | {Board[0, 2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {Board[1, 0]} | {Board[1, 1]} | {Board[1, 2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {Board[2, 0]} | {Board[2, 1]} | {Board[2, 2]} ");
    }

    public static (bool gameEnded, char winner) CheckWin()
    {
        foreach (int[][] pattern in WinPatterns)
        {
            char[] chars = pattern.ToList()
                .Select(c => Board[c[0], c[1]])
                .ToArray();

            if (chars.All(c => c == 'X'))
            {
                return (true, 'X');
            }
            
            if (chars.All(c => c == 'O'))
            {
                return (true, 'O');
            }
        }
        
        return !Board.Cast<char>().Contains(' ') ? (true, ' ') : (false, ' ');
    }
}