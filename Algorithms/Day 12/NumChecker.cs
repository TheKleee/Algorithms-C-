/*
 *  Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere.
 */

using System;

public class NumChecker
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FiveNextToFive(new[] { 2, 5, 6, 5, 17 }));
        Console.WriteLine(FiveNextToFive(new[] { 21, 6, 1234 }));
        Console.WriteLine(FiveNextToFive(new[] { 21, 5, 5 }));
        Console.WriteLine(FiveNextToFive(new[] { 5, 5 }));
    }

    public static bool FiveNextToFive(int[] a)
    {
        bool fnf = false;
        for (int i = 0; i < a.Length; i++)
        {
            fnf = i > 0 ?
                a[i] == 5 && a[i - 1] == 5 :
                false;
            if (fnf) break;
        }
        return fnf;
    }
}
