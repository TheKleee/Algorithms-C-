/*
 * Write a C# Sharp program to create a new array after replacing all the values 5 with 0 shifting all zeros to right direction.
 */

using System;
using ArrayEditor;

public static class ArrayReplacer
{

    public static void Main(string[] args)
    {
        int[] a1 = new int[] { 0, 1, 5, 2, 0, 5, 7 }.FlipArray().FiveToZero().ShiftZeroArray().FlipArray();
        int[] a2 = new int[] { 1, 2, 5, 0, 5, 0, 3, 0 }.FlipArray().FiveToZero().ShiftZeroArray().FlipArray();
        int[] a3 = new int[] { 0, 5, 1 }.FlipArray().FiveToZero().ShiftZeroArray().FlipArray();
        ReadArray.DisplayMultipleArrays(new int[][] { a1, a2, a3 });
    }
}

namespace ArrayEditor
{
    public static class ReturnArray
    {
        #region Generic Arrays:
        public static T[] BasicArray<T>(this T[] a, int length) where T : struct
        {
            #region Exceptions:
            if (a == null)
                throw new ArgumentNullException("a", "The given array must not be null!");

            if (length > a.Length || length <= 0)
                throw new ArgumentOutOfRangeException("length", "The given length is outside of the array element range!");
            #endregion exceptions />

            T[] temp = new T[length];
            for (int i = 0; i < length; i++)
                temp[i] = a[i];

            return temp;
        }

        public static T[] FlipArray<T>(this T[] a) where T : struct
        {
            if (a.Length < 1 || a == null)
                throw new NullReferenceException("The given array must contain at least one element!");

            T[] flipped = new T[a.Length];
            for (int i = 0; i < a.Length; i++)
                flipped[a.Length - 1 - i] = a[i];

            return flipped;
        }
        #endregion generic arrays />

        #region Int Arrays:
        public static int[] FiveToZero(this int[] a)
        {
            if (a.Length < 1 || a == null)
                throw new NullReferenceException("The given array must contain at least one element!");

            for (int i = 0; i < a.Length; i++)
                a[i] = a[i] == 5 ? 0 : a[i];
            return a;
        }

        public static int[] ShiftZeroArray(this int[] arr)
        {
            if (arr.Length < 1 || arr == null)
                throw new NullReferenceException("The given array must contain at least one element!");

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    int[] temp = arr.BasicArray(i);
                    for (int j = 0; j < temp.Length; j++)
                        arr[j + 1] = temp[j];

                    arr[0] = 0;
                }
            }

            return arr;
        }
        #endregion int arrays />
    }

    public static class ReadArray
    {
        public static void DisplayArray<T>(this T[] a) where T : struct
        {
            if (a.Length < 1 || a == null)
                throw new NullReferenceException("The given array must contain at least one element!");

            foreach (var r in a) Console.Write($"{r} ");
            Console.WriteLine("");
        }

        public static void DisplayMultipleArrays<T>(this T[][] multiArray) where T : struct
        {
            if (multiArray.Length < 1 || multiArray == null)
                throw new NullReferenceException("The given jagged array must contain at least one array as an element!");

            foreach (var mA in multiArray)
                mA.DisplayArray();
        }
    }
}
