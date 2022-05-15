/*
 * Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice.
 * The length of the array will be 0, 1, or 2.
 */

using System;

public class ArrayCheck
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{TenOrTwentyTwice(new[] { 10, 20, 10 })}");
        Console.WriteLine($"{TenOrTwentyTwice(new[] { 20, 20, 20 })}");
        Console.WriteLine($"{TenOrTwentyTwice(new[] { 20, 20, 10, 10 })}");
    }

    public static bool TenOrTwentyTwice(int[] a)
    {
        if (a.Length > 3) return false;

        int[] tenOrTwenty = new int[2] { 0, 0 };
        for (int i = 0; i < a.Length; i++)
        {
            tenOrTwenty[0] += (a[i] == 10) ? 1 : 0;
            tenOrTwenty[1] += (a[i] == 20) ? 1 : 0;
        }
        return tenOrTwenty[0] == 2 || tenOrTwenty[1] == 2;
    }
}
