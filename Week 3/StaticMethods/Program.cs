static class Program
{
    public static void Main(string[] args)
    {
        Scale scale = new Scale();
        Console.WriteLine(scale.DisplayWeight(69));

        scale.UseKg = false;
        Console.WriteLine(scale.DisplayWeight(69));
    }
}