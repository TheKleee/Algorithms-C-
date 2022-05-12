/*
 * Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.
 */

using System;

public class StringCondition
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{StringLenTwo("Norton", 3)}");
        Console.WriteLine($"{StringLenTwo("demi", 2)}");
        Console.WriteLine($"{StringLenTwo("do", 1)}");
        Console.WriteLine($"{StringLenTwo("n", 2)}");
    }

    public static string StringLenTwo(string data, int len)
    {
        return data.Length > 2 && data.Length - len > 1 ? data.Substring(len, 2) : data;
    }
}
