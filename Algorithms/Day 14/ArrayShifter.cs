/*
 * Write a C# Sharp program to create a new array from a given array of integers shifting all zeros to left direction.
 */

using System;
using ArrayEditor;

public static class ArrayShifter
{

    public static void Main(string[] args)
    {
        int[] a1 = new int[] { 0, 1, 0, 2, 0, 3 }.ShiftZeroArray();
        int[] a2 = new int[] { 12, 10, 0, 15, 0, 0 }.ShiftZeroArray();
        int[] a3 = new int[] { 0, 1 }.ShiftZeroArray();
        ReadArray.DisplayMultipleArrays(new int[][] { a1, a2, a3});
    }
}

namespace ArrayEditor
{
    public static class ReturnArray
    {
        public static T[] BasicArray<T>(this T[] a, int length) where T : struct
        {
            T[] temp = new T[length];
            for (int i = 0; i < length; i++)
                temp[i] = a[i];

            return temp;
        }
    
        public static int[] ShiftZeroArray(this int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    int[] temp = arr.BasicArray(i);
                    for (int j = 0; j < temp.Length; j++)
                        arr[j + 1] = temp[j];

                    arr[0] = 0;
                }
            }

            return arr;
        }
    }

    public static class ReadArray
    {
        public static void DisplayArray<T>(this T[] a) where T : struct
        {
            foreach (var r in a) Console.Write($"{r} ");
            Console.WriteLine("");
        }

        public static void DisplayMultipleArrays<T>(this T[][] multiArray) where T : struct
        {
            foreach (var mA in multiArray)
                mA.DisplayArray();
        }
    }
}
