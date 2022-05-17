/*
 * Write a C# Sharp program to check a given array of integers and return true if the given array contains two 5's next to each other,
 * or two  5 separated by one element.
 */

using System;

public class ConditionChecker
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FiveToFive(new[] { 2, 5, 6, 5, 17 }));
        Console.WriteLine(FiveToFive(new[] { 2, 5, 5, 17 }));

    }

    private static bool FiveToFive(int[] a)
    {
        bool fiveToFive = false;
        if (a.Length > 1)
            for (int i = 0; i < a.Length; i++)
                if (a[i] == 5 && a[i - 1] == 5)
                {
                    fiveToFive = true;
                    break;
                }
        return fiveToFive;
    }
}
