/*
 * Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers ( length 4),
 * replace all elements with maximum element.
 * By maximum the autor meant the element with the highest value...
 */

using System;

 public class CraftArray
{
    public static void Main(string[] args)
    {
        DisplayArrayData(MaxValue(new[] { 1, 2, 123, 7, 192 }));
        DisplayArrayData(MaxValue(new[] { 1, 2, 3, -5 }));
        DisplayArrayData(MaxValue(new[] { 2, 5, 7 }));
    }

    public static int[] MaxValue(int[] a)
    {
        int[] sum = new int[a.Length];
        int maxValue = 0;
        for (int i = 0; i < a.Length; i++)
            maxValue = a[i] > maxValue ? a[i] : maxValue;

        for (int i = 0; i < sum.Length; i++)
            sum[i] = maxValue;

        return sum;
    }

    public static void DisplayArrayData(int[] aData)
    {
        foreach (var i in aData)
            Console.Write(i + " ");
        Console.WriteLine("");
    }
}
