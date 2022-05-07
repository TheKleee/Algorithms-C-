/*
 * Write a C# Sharp program to convert the last 3 characters of a given string in upper case.
 * If the length of the string has less than 3 then uppercase all the characters.
 */

using System;

public class ConvertUpperCase
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Capitalized last 3 digits: {LastThreeChar("This Is My Form")}");
        Console.WriteLine($"Capitalized last 3 digits: {LastThreeChar("aS")}");
    }

    public static string LastThreeChar(string data)
    {
        string test = data.Substring(0, data.Length > 3 ? data.Length - 3 : 0);
        for (int i = data.Length > 3 ? data.Length - 3 : 0; i < data.Length; i++)
        {
            test += data[i].ToString().ToUpper();
        }
        return test;
    }
}
