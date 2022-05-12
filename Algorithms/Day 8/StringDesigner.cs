/*
 * Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2).
 */

using System;

public class StringDesigner
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{MiddleStrigTwoChar("TEST")}");
        Console.WriteLine($"{MiddleStrigTwoChar("TE rest ST")}");
        Console.WriteLine($"{MiddleStrigTwoChar("de")}");
        Console.WriteLine($"{MiddleStrigTwoChar("T")}");
    }

    public static string MiddleStrigTwoChar(string data)
    {
        return data.Length == 2 ? data : data.Length < 2 ? "" : data.Substring((data.Length - 1) / 2, 2);
    }
}
