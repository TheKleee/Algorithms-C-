/*
 * Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same.
 */

using System;

public class DataCheck
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{FirstTwoLastTwoMatch("abcdefgh")}");
        Console.WriteLine($"{FirstTwoLastTwoMatch("hoxyzhoho")}");
        Console.WriteLine($"{FirstTwoLastTwoMatch("asterix")}");
    }

    public static bool FirstTwoLastTwoMatch(string data)
    {
        return data.Substring(0, 2) == data.Substring(data.Length - 2);
    }
}
