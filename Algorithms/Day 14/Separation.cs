/*
 * Write a C# Sharp program to create new array from a given array of integers shifting all even numbers before all odd numbers.
 */

using System;
using ArrayEditor;

public static class Separation
{

    public static void Main(string[] args)
    {
        int[] a1 = new int[] { 0, 1, 5, 2, 4, 5, 7 }.ShiftEvenArray();
        int[] a2 = new int[] { 1, 2, 5, 0, 5, 0, 3, 0 }.ShiftEvenArray();
        int[] a3 = new int[] { 8, 5, 8 }.ShiftEvenArray();
        ReadArray.DisplayMultipleArrays(new int[][] { a1, a2, a3});
    }
}

namespace ArrayEditor
{
    public static class ReturnArray
    {
        #region Generic Arrays:
        public static T[] BasicArray<T>(this T[] a, int length) where T : struct
        {
            T[] temp = new T[length];
            for (int i = 0; i < length; i++)
                temp[i] = a[i];

            return temp;
        }

        public static T[] FlipArrayLen<T>(this T[] a) where T : struct
        {
            T[] temp = new T[a.Length];
            for (int i = 0; i < a.Length; i++)
                temp[a.Length - 1 - i] = a[i];

            return temp;
        }
        #endregion generic arrays />

        #region Int Arrays:
        public static int[] ShiftEvenArray(this int[] arr)
        {
            //Separating even and odd numbers in the array:
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    int tempA = arr[i];
                    int[] temp = arr.BasicArray(i);
                    for (int j = 0; j < temp.Length; j++)
                        arr[j + 1] = temp[j];

                    arr[0] = tempA;
                }
            }

            //Setting the first part of the array in order:
            var t = arr.GetEvenNumArray().FlipArrayLen();
            for (int i = 0; i < t.Length; i++)
                arr[i] = t[i];

            return arr;
        }

        public static int[] GetEvenNumArray(this int[] a)
        {
            int[] temp = a;
            int len = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    temp[i] = a[i];
                    len++;
                }
            }
            return temp.BasicArray(len);
        }
        #endregion int arrays />
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
