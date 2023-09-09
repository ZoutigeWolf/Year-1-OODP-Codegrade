public static class ArrayUtils
{
    public static void ReverseArray<T>(T[] arr)
    {
        RecReverseArray(arr, 0, arr.Length - 1);
    }

    private static T[] RecReverseArray<T>(T[] arr, int i, int j)
    {
        if (i >= j)
            return arr;

        (arr[i], arr[j]) = (arr[j], arr[i]);

        return RecReverseArray<T>(arr, i + 1, j - 1);
    }

    public static void PrintArray<T>(T[] arr)
    {
        foreach (T elem in arr)
        {
            Console.WriteLine(elem);
        }
    }
}