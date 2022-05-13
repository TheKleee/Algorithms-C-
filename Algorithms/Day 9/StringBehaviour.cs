/*
 * Write a C# Sharp program to create a new string from a given string. 
 * If the two characters of the given string from its beginning and
 * end are same return the given string without the first two characters otherwise return the original string.
 */

using System;

public class StringBehaviour
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{RemoveTwoIfFirstLastSame("abcdefgh")}");
        Console.WriteLine($"{RemoveTwoIfFirstLastSame("sasa")}");
        Console.WriteLine($"{RemoveTwoIfFirstLastSame("sasasa")}");
        Console.WriteLine($"{RemoveTwoIfFirstLastSame("dasamada")}");
    }

    public static string RemoveTwoIfFirstLastSame(string data)
    {
        return data.Length > 2 ? (data.Substring(0, 2) == data.Substring(data.Length - 2) ? data.Substring(2) : data) : data;
    }
}
