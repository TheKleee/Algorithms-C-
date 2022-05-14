/*
 * Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true
 * if they have the same first element or they have the same last element.
 */

using System;

 public class IntArrayCheck
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{CompareFirstLastElem(new[] {1, 2, 5, 6}, new[] {2, 3, 4, 6})}");
        Console.WriteLine($"{CompareFirstLastElem(new[] {2, 1}, new[] {2, 3, 4})}");
        Console.WriteLine($"{CompareFirstLastElem(new[] {1, 2, 5}, new[] {2, 3, 4, 6})}");
    }

    public static bool CompareFirstLastElem(int[] a1, int[] a2)
    {
        return a1.Length > 1 && a2.Length > 1 ? a1[0] == a2[0] || a1[a1.Length - 1] == a2[a2.Length - 1] : false;
    }
}
