/*
 * Write a C# Sharp program to compute the sum of the two given arrays of integers,
 * length 3 and find the array which has the largest sum.
 */

using System;

public class LargerArraySum
{
    public static void Main(string[] args)
    {
        DisplayArray<int>.Display(ComputeTwoInt(new[] { 2, 5, 7 }, new[] { 10, -15, 12}));
        DisplayArray<int>.Display(ComputeTwoInt(new[] { 12, 25, 3 }, new[] { 7, -17, 45}));
        DisplayArray<int>.Display(ComputeTwoInt(new[] { 31, 5, -23 }, new[] { 15, 15, 2}));
    }

    public static int[] ComputeTwoInt(int[] a1, int[] a2)
    {
        int[] sum = new int[2] { 0, 0 };
        for (int i = 0; i < 3; i++)
        {
            sum[0] += a1[i];
            sum[1] += a2[i];
        }

        return a1.Length == 3 && a2.Length == 3 ? 
            sum[0] > sum[1] ? a1 : a2 :
            new[] { 0, 0, 0};
    }

}

public static class DisplayArray<T>
{
    public static void Display(T[] a)
    {
        foreach (var i in a)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine(" ");
    }
}
