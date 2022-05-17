/*
 * Write a C# Sharp program to check a given array of integers and return true if every 5
 * that appears in the given array is next to another 5.
 */

using System;

public class RepeatCondition
{
    public static void Main(string[] args)
    {
        Console.WriteLine(AllFivesInRow(new[] { 2, 5, 6, 5, 18 }));
        Console.WriteLine(AllFivesInRow(new[] { 2, 3, 5, 17 }));
        Console.WriteLine(AllFivesInRow(new[] { 5, 5, 5}));
        Console.WriteLine(AllFivesInRow(new[] { 5, 2, 5, 5}));
        Console.WriteLine(AllFivesInRow(new[] { 5 }));
    }

    private static bool AllFivesInRow(int[] a)
    {
        bool isTrue = a[0] == 5;
        if (a.Length > 1)
            for (int i = 1; i < a.Length; i++) 
            { 
                if (a[i] != 5 && a[i - 1] == 5)
                {
                    isTrue = false;
                    break;
                }
            isTrue = a[i] == 5 && a[i - 1] == 5;
        }
        return isTrue;
    }
}
