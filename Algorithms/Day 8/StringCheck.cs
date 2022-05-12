/*
 * Write a C# Sharp program to check if a given string ends with "on".
 */

using System;

public class StringCheck
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{EndsWithON("norm")}");
        Console.WriteLine($"{EndsWithON("on")}");
        Console.WriteLine($"{EndsWithON("moon")}");
    }

    public static bool EndsWithON(string data)
    {
        return data.Length >= 2 && data.Substring(data.Length - 2, 2) == "on";
    }
}
