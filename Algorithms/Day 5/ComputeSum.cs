/*
 * Write a C# Sharp program to compute the sum of the two given integers.
 * If one of the given integer value is in the range 10..20 inclusive return 18.
 */

using System;

public class ComputeSum
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{SumRangeCheck(100, 23)}");
        Console.WriteLine($"{SumRangeCheck(15, 37)}");
        Console.WriteLine($"{SumRangeCheck(29, 42)}");
    }
    public static int SumRangeCheck(int x, int y)
    {
        return (x >= 10 && x <= 20 || y >= 10 && y <= 20) ? 18 : x + y;
    }
}
