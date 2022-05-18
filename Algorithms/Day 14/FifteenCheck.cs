/*
 * Write a C# Sharp program to check a given array (length will be at least 2)
 * of integers and return true if there are two values 15, 15 next to each other.
 */

using System;
using ArrayEditor;

public static class FifteenCheck
{

    public static void Main(string[] args)
    {
        int[] a1 = new int[] { 0, 1, 5, 2, 4, 5, 7 };
        int[] a2 = new int[] { 1, 2, 15, 15, 0, 3, 0 };
        int[] a3 = new int[] { 3, 5, 8 };
        int[] a4 = new int[] { 15 };
        ReadArray.DisplayArray(new bool[] { a1.TwoInARow(), a2.TwoInARow(), a3.TwoInARow(), a4.TwoInARow() });
    }
}

namespace ArrayEditor
{
    public static class DataCheck
    {
        #region Boolean Arrays:
        public static bool TwoInARow(this int[] a, int num = 15)
        {
            if(a.Length > 0)
                for (int i = 1; i < a.Length; i++)
                    if (a[i] == num && a[i - 1] == num) return true;
            return false;
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
