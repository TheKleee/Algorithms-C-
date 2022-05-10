/*
 * Write a C# Sharp program to find the larger from two given integers.
 * However if the two integers have the same remainder when divided by 7, then the return the smaller integer.
 * If the two integers are the same, return 0.
 */

using System;

public class LargerInt
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{LargerIntCheckSeven<int>(2, 2)}");
        Console.WriteLine($"{LargerIntCheckSeven<int>(77, 14)}");
        Console.WriteLine($"{LargerIntCheckSeven<int>(65, 95)}");
    }
    public static T LargerIntCheckSeven<T>(int x, int y) where T : struct
    {
        return (T)Convert.ChangeType(ReturnLICS(x, y), typeof(T));
    }

    static int ReturnLICS(int x, int y)
    {
        return x != y ? (x % 7 == y % 7) ? (x < y ? x : y) : (x > y ? x : y) : 0;
    }
}
