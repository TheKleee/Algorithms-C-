//Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive,
//or they are both in the range 50..60 inclusive.

using System;

public class CheckRange
{
    static void Main(string[] args)
    {
        Console.WriteLine($"23 and 47 are in the given range? {RangeCheck(23, 47)}");
        Console.WriteLine($"52 and 47 are in the given range? {RangeCheck(52, 47)}");
    }

    public static bool RangeCheck(int x, int y)
    {
        return x >= 40 && x <= 60 && y >= 40 && y <= 60;
    }
}
