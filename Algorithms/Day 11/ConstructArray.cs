/*
 * Write a C# Sharp program to check a given array of integers, length 3 and create a new array.
 * If there is a 5 in the given array immediately followed by a 7 then set 7 to 1.
 */

using System;

public class ConstructArray
{
    public static void Main(string[] args)
    {
        DisplayArray<int>.Display(FiveThenSevenToOne(new[] { 2, 5, 7 }));
        DisplayArray<int>.Display(FiveThenSevenToOne(new[] { 5, 7, 7 }));
        DisplayArray<int>.Display(FiveThenSevenToOne(new[] { 5, 7, 5 }));
        DisplayArray<int>.Display(FiveThenSevenToOne(new[] { 5, 5, 7 }));
    }

    public static int[] FiveThenSevenToOne(int[] a)
    {
        if (a.Length == 3)
        {
            int five;
            for (int i = 0; i < a.Length; i++)
            {
                five = i > 0 ? a[i - 1] : 0;
                if (a[i] == 7 && five == 5)
                    a[i] = 1;
            }
        }

        return a;   //Don't change the array
    }

}

public static class DisplayArray<T>
{
    public static void Display(T[] a)
    {
        foreach (var i in a)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine(" ");
    }
}
