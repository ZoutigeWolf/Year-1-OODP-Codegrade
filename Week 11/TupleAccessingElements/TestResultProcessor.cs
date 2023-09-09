public static class TestResultProcessor
{
    public static Tuple<double, bool> GetTestResult(double points, double maxPoints)
    {
        double grade = (points / maxPoints) * 10;

        return Tuple.Create(grade, grade >= 5.5);
    }

    public static void PrintTestResult(Tuple<double, bool> data)
    {
        Console.WriteLine($"Grade: {data.Item1}");
        Console.WriteLine(data.Item2 ? "Passed" : "Dit not pass");
    }
}