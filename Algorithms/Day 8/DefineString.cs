/*
 * Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2).
 */

using System;

public class DefineString
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{RemoveFirstAndLastChar("This is a string")}");
        Console.WriteLine($"{RemoveFirstAndLastChar("T")}");
    }

    public static string RemoveFirstAndLastChar(string data)
    {
        return data.Length < 2 ? "" : data.Substring(1, data.Length - 2);
    }
}
