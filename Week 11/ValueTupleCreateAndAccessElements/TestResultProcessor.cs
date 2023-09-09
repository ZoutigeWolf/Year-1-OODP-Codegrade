public static class TestResultProcessor
{
    public static (double grade, bool passed) GetTestResult(double points, double maxPoints)
    {
        double grade = (points / maxPoints) * 10;

        return (grade, grade >= 5.5);
    }

    public static void PrintTestResult((double grade, bool passed) data)
    {
        Console.WriteLine($"Grade: {data.grade}");
        Console.WriteLine(data.passed ? "Passed" : "Dit not pass");
    }
}