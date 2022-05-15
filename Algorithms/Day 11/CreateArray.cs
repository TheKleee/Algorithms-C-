/*
 * Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.
 */

using System;

public class CreateArray
{
    public static void Main(string[] args)
    {
        DisplayArray<int>.Display(MiddleElements(new[] { 2, 5, 7, 12 }));
        DisplayArray<int>.Display(MiddleElements(new[] { 2, 5, 7 }));
        DisplayArray<int>.Display(MiddleElements(new[] { 12, 1 }));
    }

    public static int[] MiddleElements(int[] a)
    {
        return a.Length % 2 == 0 ?
            new[] { a[a.Length / 2 - 1], a[a.Length / 2] } :
            new[] { 0, 0 };
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
