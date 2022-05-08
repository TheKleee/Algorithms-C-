/*
 * Write a C# Sharp program to check a specified number is present in a given array of integers.
 */

using System;
using System.Linq;

public class IntegerCheckLinq
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"{ContainsIntLinq(arr, 3)}");
        Console.WriteLine($"{ContainsIntLinq(arr, 7)}");
    }
    public static bool ContainsIntLinq(int[] intArr, int contains)
    {
        if (intArr.Contains(contains)) return true;
        return false;
    }
}

//Without using System.Linq:
public class IntegerCheck
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"{ContainsInt(arr, 3)}");
        Console.WriteLine($"{ContainsInt(arr, 7)}");
    }
    public static bool ContainsInt(int[] intArr, int contains)
    {
        for (int i = 0; i < intArr.Length; i++)
            if (contains == intArr[i])
                return true;

        return false;
    }
}
