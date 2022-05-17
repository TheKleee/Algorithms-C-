/*
 * Write a C# Sharp program to check a given array of integers and return true if
 * the given array contains either 2 even or 2 odd values all next to each other. 
 */

using System;

public class EvenOrOdd
{
    public static void Main(string[] args)
    {
        Console.WriteLine(InARow(new[] { 2, 5, 6, 5, 18 }));
        Console.WriteLine(InARow(new[] { 2, 3, 5, 17 }));

    }

    private static bool InARow(int[] a)
    {
        bool evenOrOdd = false;
        if (a.Length > 1)
            for (int i = 1; i < a.Length; i++)
                if (a[i] % 2 == 0 && a[i - 1] % 2 == 0 || a[i] % 2 == 1 && a[i - 1] % 2 == 1)
                {
                    evenOrOdd = true;
                    break;
                }
        return evenOrOdd;
    }
}
