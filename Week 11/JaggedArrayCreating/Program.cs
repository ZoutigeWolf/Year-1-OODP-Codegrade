public class Program
{
    public static void Main()
    {
        Console.WriteLine("How many departments?");
        int departments = int.Parse(Console.ReadLine() ?? "0");

        int[][] data = new int[departments][];

        for (int i = 0; i < departments; i++)
        {
            List<int> sales = new List<int>();
            
            Console.WriteLine($"How many sales for department {i + 1}?");
            int salesAmount = int.Parse(Console.ReadLine() ?? "0");

            for (int j = 0; j < salesAmount; j++)
            {
                Console.WriteLine($"Enter amount for sale {j + 1}");
                int amount = int.Parse(Console.ReadLine() ?? "0");

                sales.Add(amount);
            }

            data[i] = sales.ToArray();
        }
        
        SalesHelper.PrintSalesData(data);
    }
}