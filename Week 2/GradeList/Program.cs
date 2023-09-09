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

        int passed = 0;

        foreach (double grade in studentGrades)
        {
            if (grade >= 5.5)
                passed++;
        }

        Console.WriteLine($"{passed} out of {studentGrades.Count} students passed");
    }
}