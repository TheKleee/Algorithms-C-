/*
 * Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others.
 * It's formulated strangely, however this means that difference between any two of these three numbers needs to be at least 20.
 */

using System;

public class ThreeInt
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{TwentyDifferenceOrMore<bool>(1, 2, 7)}");
        Console.WriteLine($"{TwentyDifferenceOrMore<bool>(107, 14, 52)}");
        Console.WriteLine($"{TwentyDifferenceOrMore<bool>(95, 65, 12)}");
    }
    public static T TwentyDifferenceOrMore<T>(int x, int y, int z) where T : struct
    {
        return (T)Convert.ChangeType(Math.Abs(x - y) >= 20 || Math.Abs(x - z) >= 20 || Math.Abs(z - y) >= 20, typeof(T));
    }
}
