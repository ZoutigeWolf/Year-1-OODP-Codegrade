namespace LengthyCaseOfLingo;
class Program
{
    const string word = "Length";

    static void Main(string[] args)
    {
        Console.WriteLine("You have one chance to guess this six-letter word:\nLe..th");

        string guess = Console.ReadLine() ?? "";

        if (guess == word)
        {
            Console.WriteLine("Correct!");
            return;
        }

        if (guess.ToLower() == word.ToLower())
        {
            Console.WriteLine("Kind of correct; the case was just wrong");
            return;
        }

        if (guess.Length != 6)
        {
            Console.WriteLine("Incorrect! That is not even a six-letter word!");
            return;
        }

        Console.WriteLine("Incorrect!");
    }
}

