/*
 * Write a C# Sharp program to create a new string without the first and last character of a given string of any length.
 */

using System;

public class StringEditor
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
