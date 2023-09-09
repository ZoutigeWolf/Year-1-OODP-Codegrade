namespace ClearConditions;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your age?");
        int age1 = int.Parse(Console.ReadLine() ?? "1");

        Console.WriteLine("What is the age of the student next to you?");
        int age2 = int.Parse(Console.ReadLine() ?? "1");

        Console.WriteLine(age1 == age2 ? "Your ages are equal" : age1 < age2 ? "You are younger" : "You are older");
    }
}