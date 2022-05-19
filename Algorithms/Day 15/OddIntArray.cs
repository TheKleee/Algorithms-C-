/*
 *  Write a C# Sharp program to create a new array of given length using the odd numbers from a given array of positive integers.
 */

using System;
using ArrayEditor;

#region Area where Junior can change things:
public static class ArrayReplacer
{

    public static void Main(string[] args)
    {
        try
        {
            int[] a1 = new int[] { 15, 20, 33 }.MustBePositive().OddNumbersArray(1);
            int[] a2 = new int[] { 13, 3, 12, 33, 77 }.MustBePositive().OddNumbersArray(3);
            int[] a3 = new int[] { 1, 0, 33, 77, 121, 927 }.MustBePositive().OddNumbersArray(5);
            ReadArray.DisplayMultipleArrays(new int[][] { a1, a2, a3 });
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}\n{e.StackTrace}");
        }
    }
}
#endregion junior's influence ends here />


#region Junior can't touch this:
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
        #endregion generic arrays />

        #region Int Arrays:
        public static int[] OddNumbersArray(this int[] a, int length)
        {
            int[] OddArray = new int[a.Length];
            int oddNumbers = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] % 2 == 1)
                {
                    OddArray[oddNumbers] = a[i];
                    oddNumbers++;
                }
            }
            if (length > oddNumbers)
                throw new ArgumentOutOfRangeException("length", "The given length must not be greater than " +
                    "the number of odd integers in the given array!");

            return OddArray.BasicArray(length);
        }

        public static int[] MustBePositive(this int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] < 0) 
                    throw new ArgumentException("All arguments in the given array must be positive numbers!", "a");

            return a;
        } 
        #endregion int arrays />
    }

    public static class ReadArray
    {
        public static void DisplayArray<T>(this T[] a) where T : struct
        {
            if (a.Length < 1 || a == null)
                throw new ArgumentNullException("The given array must contain at least one element!");

            foreach (var r in a) Console.Write($"{r} ");
            Console.WriteLine("");
        }

        public static void DisplayMultipleArrays<T>(this T[][] multiArray) where T : struct
        {
            if (multiArray.Length < 1 || multiArray == null)
                throw new ArgumentNullException("The given jagged array must contain at least one array as an element!");

            foreach (var mA in multiArray)
                mA.DisplayArray();
        }
    }
}
#endregion ends here />
