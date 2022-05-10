/*
 * Write a C# Sharp program to check two given integers, each in the range 10..99.
 * Return true if a digit appears in both numbers, such as the 3 in 13 and 33.
 */

using System;

public class IntRangeCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{DigitApperasInRange<bool>(54, 2)}");
        Console.WriteLine($"{DigitApperasInRange<bool>(17, 14)}");
        Console.WriteLine($"{DigitApperasInRange<bool>(65, 95)}");
    }
    public static T DigitApperasInRange<T>(int x, int y) where T : struct
    {
        return (T)Convert.ChangeType(ReturnDAIR(x, y), typeof(T));
    }

    static bool ReturnDAIR(int x, int y)
    {
        return x < 99 || y < 99 ? (x % 10 == y % 10 || x / 10 % 10 == y / 10 % 10) : false;
    }
}
