/*
 * Write a C# Sharp program to check if the value of each element is equal or greater than the value of
 * previous element of a given array of integers.
 */

using System;
using ArrayEditor;

public static class OrderCheck
{

    public static void Main(string[] args)
    {
        int[] a1 = new int[] { 0, 1, 5, 2, 4, 5, 7 };
        int[] a2 = new int[] { 1, 2, 5, 0, 5, 0, 3, 0 };
        int[] a3 = new int[] { 3, 5, 8 };
        ReadArray.DisplayArray(new bool[] { a1.IncrescentOrder(), a2.IncrescentOrder(), a3.IncrescentOrder() });
    }
}

namespace ArrayEditor
{
    public static class DataCheck
    {
        #region Boolean Arrays:
        public static bool IncrescentOrder(this int[] a)
        {
            for (int i = 1; i < a.Length; i++)
                if (a[i] < a[i - 1]) return false;
            return true;
        }
        #endregion boolean arrays />
    }

    public static class ReadArray
    {
        public static void DisplayArray<T>(this T[] a) where T : struct
        {
            foreach (var r in a)
                Console.WriteLine($"{r} ");
        }
    }
}
