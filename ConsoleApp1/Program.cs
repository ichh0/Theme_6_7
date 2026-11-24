using System;

public class Program
{
    public static int[] SortAscending(int[] arr)
    {
        int[] result = (int[])arr.Clone();
        Array.Sort(result);
        return result;
    }

    public static int[] SortDescending(int[] arr)
    {
        int[] result = (int[])arr.Clone();
        Array.Sort(result);
        Array.Reverse(result);
        return result;
    }
    public static int[] MergeArrays(int[] a, int[] b)
    {
        int[] result = new int[a.Length + b.Length];
        Array.Copy(a, 0, result, 0, a.Length);
        Array.Copy(b, 0, result, a.Length, b.Length);
        return result;
    }
    public static int AbsoluteDifference(int n)
    {
        int diff = Math.Abs(n - 123);
        return n > 123 ? diff * 3 : diff;
    }

    public static void Main()
    {
        int[] arr1 = { 5, 2, 8, 1, 9 };
        int[] arr2 = { 4, 7, 3, 6, 0 };

        Console.WriteLine("По возрастанию: " + string.Join(", ", SortAscending(arr1)));
        Console.WriteLine("По убыванию: " + string.Join(", ", SortDescending(arr1)));
        Console.WriteLine("Объединение: " + string.Join(", ", MergeArrays(arr1, arr2)));

        Console.WriteLine("AbsoluteDifference(100) = " + AbsoluteDifference(100));
        Console.WriteLine("AbsoluteDifference(123) = " + AbsoluteDifference(123));
        Console.WriteLine("AbsoluteDifference(200) = " + AbsoluteDifference(200));
    }
}