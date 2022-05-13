/*
 * Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string.
 * If the length of the given string is less than 2 use the whole string.
 */

using System;

public class DataBehaviour
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{TwoCharCopyThreeTimes("abcdefgh")}");
        Console.WriteLine($"{TwoCharCopyThreeTimes("a")}");
        Console.WriteLine($"{TwoCharCopyThreeTimes("ahhaaxxx")}");
        Console.WriteLine($"{TwoCharCopyThreeTimes("xD")}");
    }

    public static string TwoCharCopyThreeTimes(string data)
    {
        return data.Length > 2 ? data.Substring(0, 2) + data.Substring(0, 2) + data.Substring(0, 2) : data;
    }
}
