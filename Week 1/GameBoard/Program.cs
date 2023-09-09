namespace GameBoard;
class Program {
    public static void Main(string[] args)
    {
        int GetSize()
        {
            Console.WriteLine("What size?");
            int size = int.Parse(Console.ReadLine() ?? "2");

            return size < 2 ? GetSize() : size;
        }

        int size = GetSize();

        List<List<string>> board = new List<List<string>>();

        for (int y = 0; y < size; y++)
        {
            List<string> row = new List<string>();

            for (int x = 0; x < size; x++)
            {
                if (size % 2 == 0)
                    row.Add((x + y) % 2 == 0 ? "W" : "B");

                else
                    row.Add((x + y) % 2 == 0 ? "B" : "W");
            }

            board.Add(row);
        }

        board.ForEach(row => Console.WriteLine(string.Join("", row.ToArray())));

    }
}