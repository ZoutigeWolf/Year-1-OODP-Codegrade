public static class SalesHelper
{
    public static void PrintSalesData(int[][] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine($"Sales data for department {i + 1}:");
            
            for (int j = 0; j < data[i].Length; j++)
            {
                Console.WriteLine($" - {data[i][j]}");
            }
            
            Console.WriteLine();
        }
    }
}