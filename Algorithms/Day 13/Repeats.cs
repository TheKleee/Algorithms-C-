/*
 * Write a C# Sharp program to check a given array of integers and return true if
 * the value 5 appears 5 times and there are no 5 next to each other.
 */

using System;

public class Repeats
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FiveTimesFiveNotInRow(new[] { 2, 5, 6, 5, 18 }));
        Console.WriteLine(FiveTimesFiveNotInRow(new[] { 2, 3, 5, 17 }));
        Console.WriteLine(FiveTimesFiveNotInRow(new[] { 5, 3, 5, 17, 5, 3, 5, 2, 5 }));
    }

    private static bool FiveTimesFiveNotInRow(int[] a)
    {
        bool fiveCheck = false;
        int five = a[0] == 5 ? 1 : 0;
        if (a.Length > 1)
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == 5 && a[i - 1] == 5)
                {
                    fiveCheck = false;
                    break;
                }

                five += a[i]== 5 ? 1 : 0;
                if(five == 5)
                {
                    fiveCheck = true;
                    break;
                }
            }
        return fiveCheck;
    }
}
