/*
 * Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element. 
 */

using System;
using System.Linq;

//With Linq:
public class IntegerFourLinq
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"{FirstForContainsIntLinq(arr, 3)}");
        Console.WriteLine($"{FirstForContainsIntLinq(arr, 5)}");
        Console.WriteLine($"{FirstForContainsIntLinq(arr, 7)}");
    }
    public static bool FirstForContainsIntLinq(int[] intArr, int contains)
    {
        return intArr.Length < 4 ? intArr.Contains(contains) : intArr.Take(4).Contains(contains);
    }
}

//Without Linq:
public class IntegerFour
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"{FirstForContainsInt(arr, 3)}");
        Console.WriteLine($"{FirstForContainsInt(arr, 5)}");
        Console.WriteLine($"{FirstForContainsInt(arr, 7)}");
    }
    public static bool FirstForContainsInt(int[] intArr, int contains)
    {
        int len = intArr.Length > 4 ? 4 : intArr.Length;
        for (int i = 0; i < len; i++)
            if (contains == intArr[i]) 
                return true;

        return false;
    }
}
