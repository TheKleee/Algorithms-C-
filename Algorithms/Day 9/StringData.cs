/*
 * Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'.
 * If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string.
 */

using System;

public class StringData
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{AbcXyz("abcdefgh")}");
        Console.WriteLine($"{AbcXyz("xyzhoho")}");
        Console.WriteLine($"{AbcXyz("asterix")}");
    }

    public static string AbcXyz(string data)
    {
        string abcOrXyz = data.Substring(0, 3);
        return abcOrXyz == "abc" || abcOrXyz == "xyz" ? abcOrXyz : "";
    }
}
