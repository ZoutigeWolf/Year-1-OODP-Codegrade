namespace ListOfGrades;

class Program
{
    public static void Main(string[] args)
    {
        List<double> studentGrades = new List<double>
        {
            7,
            5.5,
            3.2,
            10,
            4.5
        };

        int passed = studentGrades.Count(x => x >= 5.5);

        Console.WriteLine($"{passed} out of {studentGrades.Count} students passed");
    }
}