public class Program
{
    static void Main()//           .  .
    {   //                0  1  2  3  4
        int[] myArray = { 1, 3, 5, 7, 9 };
        Console.Write("Give a number to search for: ");
        int targetValue = Convert.ToInt32(Console.ReadLine());
        int index = RecSearch.BinarySearch(myArray, targetValue);

        if (index != -1)
        {
            Console.WriteLine($"Found {targetValue} at index {index}");
        }
        else
        {
            Console.WriteLine($"{targetValue} was not found in the array");
        }
    }
}