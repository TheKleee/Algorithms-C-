/*
 * Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) in left direction and return the new array.
 */

using System;

 public class ArrayModification
{
    public static void Main(string[] args)
    {
       
        DisplayArrayData(RotateArrayLeft(new[] {1, 2, 5, 6}));
        DisplayArrayData(RotateArrayLeft(new[] {2, 5, 6}));
        DisplayArrayData(RotateArrayLeft(new[] {1, 2, 123, 7, 192}));
    }

    public static int[] RotateArrayLeft(int[] a)
    {
        int[] sum = new int[a.Length];
        for (int i = 1; i < a.Length; i++)
            sum[i - 1] = a[i];
        sum[sum.Length - 1] = a[0];

        return sum;
    }

    public static void DisplayArrayData(int[] aData)
    {
        foreach (var i in aData)
            Console.Write(i + " ");
        Console.WriteLine("");
    }
}
