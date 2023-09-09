namespace LowKeyLesson;
class Program
{
    public static void Main(string[] args)
    {
        int score = 0;

        Console.WriteLine("Answer the following MCQs:");

        Console.WriteLine("Which of the following is NOT a valid type in C#?");
        Console.WriteLine("A: bool\nB: int\nC: var\nD: string");

        string answer = (Console.ReadLine() ?? "").ToUpper();

        if (answer == "C") score++;

        Console.WriteLine("\nWhat happens if you execute the following line C#?");
        Console.WriteLine("int x = 1.23;");
        Console.WriteLine("A: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error");

        answer = (Console.ReadLine() ?? "").ToUpper();

        if (answer == "D") score++;

        Console.WriteLine("\nConsider the following line:\ndouble d = 1.23;");
        Console.WriteLine("What are TWO ways to convert variable d to an int?");
        Console.WriteLine("A: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = Convert.ToInt32(d)");

        Console.WriteLine("Your first answer:");
        answer = (Console.ReadLine() ?? "").ToUpper();

        Console.WriteLine("Your second answer:");
        string answer2 = (Console.ReadLine() ?? "").ToUpper();

        string[] correctAnswers = new string[2] { "A", "D" };

        if (correctAnswers.Contains(answer) && correctAnswers.Contains(answer2) && answer != answer2) score++;

        Console.WriteLine($"Your score: {score} out of 3. " + (score == 3 ? "Well done!" : ""));
    }
}