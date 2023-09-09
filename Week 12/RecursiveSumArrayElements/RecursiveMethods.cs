public static class RecursiveMethods
{
    public static int RecSumArray(int[] arr, int n) =>
        n == 0 ? arr[n] : arr[n] + RecSumArray(arr, n - 1);
}