static class Program
{
    public static void Main()
    {
        Ventilator ventilator = new();
        for (int i = 0; i < 4; i++)
        {
            ventilator.PressButton(i);
            Console.WriteLine(ventilator.Blow());
        }
    }
}