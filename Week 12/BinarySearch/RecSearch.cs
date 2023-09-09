public static class RecSearch
{
    public static int BinarySearch(int[] arr, int value)
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch(int[] arr, int value, int low, int high)
    {
        int middle = (int)Math.Floor((low + high) / 2.0);
        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine($"{low} - {high} : {middle}\n");
        int midValue = arr[middle];

        if (midValue == value)
            return middle;

        if (midValue > value)
            return middle == 0 ? -1 : BinarySearch(arr, value, low, middle - 1);

        if (midValue < value)
            return middle == arr.Length - 1 ? -1 : BinarySearch(arr, value, middle + 1, high);

        return -1;
    }
}