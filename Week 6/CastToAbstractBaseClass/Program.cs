static class Program
{
    public static void Main()
    {
        List<Bill> bills = new List<Bill>()
        {
            new ElectricityBill(50, "John Smith"),
            new ElectricityBill(75, "Jane Doe"),
            new GasBill(100, "Bob Johnson", false),
            new GasBill(125, "John Doe", true)
        };
        
        bills.ForEach(b => Console.WriteLine(b.GetDescription()));

        double total = bills.Select(b => b.Amount).Sum();
        
        Console.WriteLine($"Total amount: {total}");
    }
}