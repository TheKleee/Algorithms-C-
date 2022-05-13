/*
 * Write a C# Sharp program to combine two given strings.
 * If the given strings have different length remove the characters from the longer string.
 */

using System;

public class CombineData
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{SameLenStr("abcdefgh", "sad")}");
        Console.WriteLine($"{SameLenStr("ab", "sz")}");
        Console.WriteLine($"{SameLenStr("abk", "sxtz")}");
    }

    public static string SameLenStr(string s1, string s2)
    {
        return s1.Length > s2.Length ? s1.Substring(0, s2.Length) + s2 : s1 + s2.Substring(0, s1.Length);
    }
}
