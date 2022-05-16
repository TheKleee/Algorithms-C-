/*
 * Write a C# Sharp program to check whether a given array of integers contains 5's and 7's.
 */

using System;

public class Container
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CeckFiveOrSeven(new[] { 2, 5, 6, 5, 17 }));
        Console.WriteLine(CeckFiveOrSeven(new[] { 21, 6, 1234 }));
        Console.WriteLine(CeckFiveOrSeven(new[] { 21, 3, 7 }));
        Console.WriteLine(CeckFiveOrSeven(new[] { 2, 1 }));
    }

    public static bool CeckFiveOrSeven(int[] a)
    {
        bool fnf = false;
        for (int i = 0; i < a.Length; i++)
        {
            fnf = a[i] == 5 || a[i] == 7;
            if (fnf) break;
        }
        return fnf;
    }
}
