/*
 * Write a C# Sharp program to compute the sum of values in a given array of integers except the number 17.
 * Return 0 if the given array has no integer.
 */

using System;

public class Sum
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ExceptSeventeen(new[] { 2, 5, 17, 17 }));
        Console.WriteLine(ExceptSeventeen(new[] { 21, 1234 }));
        Console.WriteLine(ExceptSeventeen(new[] { 21 }));
        Console.WriteLine(ExceptSeventeen(new[] { 17 }));
    }

    public static int ExceptSeventeen(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
            sum += a[i] != 17 ? a[i] : 0;

        return sum;
    }
}
