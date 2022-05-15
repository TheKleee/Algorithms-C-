/*
 * Write a C# Sharp program to create a new array from two give array of integers, each length 3.
 */

using System;

public class NewArray
{
    public static void Main(string[] args)
    {
        DisplayArray<int>.Display(MiddleElements(new[] { 2, 5, 7 }, new[] { 1, 2, 3 }));
        DisplayArray<int>.Display(MiddleElements(new[] { 12, 25, 73 }, new[] { 31, 254, 367 }));
    }

    public static int[] MiddleElements(int[] a1, int[] a2)
    {
        int[] a3 = new int[a1.Length + a2.Length];

        for (int i = 0; i < a1.Length; i++)
            a3[i] = a1[i];

        for (int i = 0; i < a2.Length; i++)
            a3[i + a1.Length] = a2[i];

        return a3.Length == 6 ? a3 : new[] { 0, 0, 0, 0, 0, 0};
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
