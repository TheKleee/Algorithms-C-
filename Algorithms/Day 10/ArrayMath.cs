/*
 *  Write a C# Sharp program to compute the sum of the elements of an given array of integers.
 */

using System;

 public class ArrayMath
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{SumOfElements(new[] {1, 2, 5, 6})}");
        Console.WriteLine($"{SumOfElements(new[] {2, 1})}");
        Console.WriteLine($"{SumOfElements(new[] {1, 2, 5})}");
    }

    public static int SumOfElements(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
            sum += a[i];
        return sum;
    }
}
