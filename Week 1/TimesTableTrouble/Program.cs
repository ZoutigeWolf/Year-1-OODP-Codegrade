using System.Text;

namespace TimesTableTrouble;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number from 2-9:");
        int number = int.Parse(Console.ReadLine() ?? "2");

        if (number < 2) number = 2;
        if (number > 9) number = 9;

        List<List<string>> table = new List<List<string>>();

        for (int y = 1; y <= number; y++)
        {
            List<string> row = new List<string>();

            for (int x = 1; x <= number; x++)
            {
                row.Add((x * y).ToString());
            }

            table.Add(row);
        }

        string r = "  |   " + string.Join("   ", table[0]);
        Console.WriteLine(r);
        Console.WriteLine(string.Empty.PadLeft(r.Length + 1, '-'));

        foreach (List<string> row in table)
        {
            Console.WriteLine($"{row[0]} |   " + JoinNumbers(row.ToArray()));
        }
    }

    static string JoinNumbers(string[] numbers)
    {
        StringBuilder res = new StringBuilder();

        for (int i = 0; i < numbers.Length; i++)
        {
            string n = numbers[i];

            res.Append(n);

            if (i == numbers.Length - 1) break;

            for (int j = 0; j < 4 - numbers[i + 1].Length; j++)
            {
                res.Append(" ");
            }
        }

        return res.ToString();
    }
}