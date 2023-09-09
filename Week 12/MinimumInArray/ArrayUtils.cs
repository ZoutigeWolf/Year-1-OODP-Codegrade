public static class ArrayUtils
{
    public static int FindMinimum(int[] arr)
    {
        return RecMinimum(arr, arr.Length - 1);
    }

    private static int RecMinimum(int[] arr, int n)
    {
        return n == 1 ? arr[0] : Math.Min(arr[n - 1], RecMinimum(arr, n - 1));
    }
}