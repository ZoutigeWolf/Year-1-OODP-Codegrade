namespace SquarePair;

public class Program
{
    public static void Main(string[] args)
    {
        Square s1 = new Square(5);
        Square s2 = new Square(10);

        Console.WriteLine($"Side: {s1.Side}\nArea: {s1.Area()}\nPerimeter: {s1.Perimeter()}");
        Console.WriteLine($"Side: {s2.Side}\nArea: {s2.Area()}\nPerimeter: {s2.Perimeter()}");
    }
}