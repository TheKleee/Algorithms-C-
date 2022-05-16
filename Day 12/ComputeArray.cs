/*
 * Write a C# Sharp program to compute the difference between the largest and smallest values in a given array of integers and length one or more.
 */

using System;

public class ComputeArray
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LargestMinusSmallest(new[] { 2, 5, 7 }));
        Console.WriteLine(LargestMinusSmallest(new[] { 21, 1234 }));
        Console.WriteLine(LargestMinusSmallest(new[] { 21 }));
    }

    public static int LargestMinusSmallest(int[] a)
    {
        int[] smallLarge = new int[2];
        for (int i = 0; i < a.Length; i++)
        {
            smallLarge[0] = i > 0 ? (a[i] < a[i - 1] ? a[i] : a[i - 1]) : i;
            smallLarge[1] = i > 0 ? (a[i] > a[i - 1] ? a[i] : a[i - 1]) : i;
        }

        return smallLarge[1] - smallLarge[0];
    }
}
