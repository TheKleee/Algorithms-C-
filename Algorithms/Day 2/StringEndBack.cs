//Write a C# Sharp program to create a new string taking the first 3 characters of a given string
// and return the string with the 3 characters added at both the front and back.
//If the given string length is less than 3, use whatever characters are there.

using System;

public class StringEndBack
{
    static void Main(string[] args)
    {
        Console.WriteLine($" {StringThreeEdit("someting")}");
        Console.WriteLine($" {StringThreeEdit("ty")}");
    }

    private static string StringThreeEdit(string data)
    {
        string test = data.Substring(0, data.Length > 3 ? 3 : data.Length);
        return test + data + test;
    }
}
