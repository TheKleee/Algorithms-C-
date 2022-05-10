/*
 * Write a C# Sharp program to compute the sum of two given non-negative integers x and y
 * as long as the sum has the same number of digits as x.
 * If the sum has more digits than x then return x without y.
 */

using System;

public class IntSum
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{IntSumOrX<int>(54, 2)}");
        Console.WriteLine($"{IntSumOrX<int>(17, 14)}");
        Console.WriteLine($"{IntSumOrX<int>(65, 95)}");
    }
    public static T IntSumOrX<T>(int x, int y) where T : struct
    {
        return (T) Convert.ChangeType(ReturnISOX(x, y), typeof(T));
    }

    static int ReturnISOX(int x, int y)
    {
        int sum = Math.Abs(x) + Math.Abs(y), xVal = Math.Abs(x);
        int[] digits = { sum, xVal }, count = { 0, 0 };
        for (int i = 0; i < digits.Length; i++)
            while (digits[i] > 0)
            {
                digits[i] = digits[i] / 10;
                count[i]++;
            }
        return count[0] == count[1] ? sum : xVal;
    }
}


//To String:
public class IntSumString
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{IntSumOrXString<int>(54, 2)}");
        Console.WriteLine($"{IntSumOrXString<int>(17, 14)}");
        Console.WriteLine($"{IntSumOrXString<int>(65, 95)}");
    }
    public static T IntSumOrXString<T>(int x, int y) where T : struct
    {
        return (T) Convert.ChangeType(ReturnISOXString(x, y), typeof(T));
    }

    static int ReturnISOXString(int x, int y)
    {
        int sum = Math.Abs(x) + Math.Abs(y), xVal = Math.Abs(x);
        return sum.ToString().Length == xVal.ToString().Length ? sum : xVal;
    }
}
