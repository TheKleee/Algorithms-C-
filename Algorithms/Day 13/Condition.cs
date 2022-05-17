/*
 * Write a C# Sharp program to check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array.
 */

using System;

public class Condition
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ThreeToFive(new[] { 2, 5, 6, 5, 17 }));
        Console.WriteLine(ThreeToFive(new[] { 2, 3, 5, 17 }));

    }

    private static bool ThreeToFive(int[] a)
    {
        bool ThreeToFive = false;
        if (a.Length > 1)
            for (int i = 1; i < a.Length; i++)
                if (a[i] == 3 && a[i - 1] == 5 || a[i] == 5 && a[i - 1] == 3)
                {
                    ThreeToFive = true;
                    break;
                }
        return ThreeToFive;
    }
}
