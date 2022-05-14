/*
 * Write a C# Sharp program to reverse a given array of integers and length 5.
 * I'll just make it whatever length...
 */

using System;

 public class ArrayEditor
{
    public static void Main(string[] args)
    {
        DisplayArrayData(ReverseArray(new[] { 1, 2, 123, 7, 192 }));
        DisplayArrayData(ReverseArray(new[] { 1, 2, 5, 6 }));
        DisplayArrayData(ReverseArray(new[] { 2, 5, 6 }));
    }

    public static int[] ReverseArray(int[] a)
    {
        int[] sum = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
            sum[a.Length - i - 1] = a[i];

        return sum;
    }

    public static void DisplayArrayData(int[] aData)
    {
        foreach (var i in aData)
            Console.Write(i + " ");
        Console.WriteLine("");
    }
}
