/*
 *  Write a C# Sharp program to compute the sum of the numbers in a given array
 *  except those numbers starting with 5 followed by at least one 6.
 *  Return 0 if the given array has no integer.
 */

using System;

public class Numbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SumExceptFiveFollowedBySix(new[] { 2, 5, 6, 17, 17 }));
        Console.WriteLine(SumExceptFiveFollowedBySix(new[] { 21, 6, 1234 }));
        Console.WriteLine(SumExceptFiveFollowedBySix(new[] { 21, 5, 6 }));
        Console.WriteLine(SumExceptFiveFollowedBySix(new[] { 6, 17 }));
    }

    public static int SumExceptFiveFollowedBySix(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
            sum += i > 0 ? 
                a[i] == 6 && a[i - 1] == 5 ? 0 : a[i] :
                a[i];

        return sum;
    }
}
