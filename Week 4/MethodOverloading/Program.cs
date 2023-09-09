static class Program
{
    public static void Main(string[] args)
    {
        PersonalInformation.PrintName("Guus");
        PersonalInformation.PrintName("Guus", "Kamphuis");
        PersonalInformation.PrintName('G', "Kamphuis");

        Console.WriteLine(PersonalInformation.IncreaseSalary(69420));
        Console.WriteLine(PersonalInformation.IncreaseSalary(69420, 0.50));
    }
}