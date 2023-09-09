namespace FizzBuzz;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Start number?");
        int start = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("End number?");
        int end = int.Parse(Console.ReadLine() ?? "0");

        for (int i = start; i <= end; i++)
        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;

            Console.WriteLine(fizz || buzz ? (fizz ? "Fizz" : "") + (buzz ? "Buzz" : "") : i);
        }
    }
}