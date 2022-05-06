//Write a C# Sharp program to check if a given string starts with 'C#' or not.

using System;

public class StartsWithCSharp
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Starts with C#? {CSharpStart("C# Program")}");
        Console.WriteLine($"Starts with C#? {CSharpStart("C++ Program")}");
    }

    private static bool CSharpStart(string data)
    {
        return data.StartsWith("C#");
    }
}

//Without string methods:
public class StartsWithCSharpNoSM
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Starts with C#? {CSharpStartNoSM("C# Program")}");
        Console.WriteLine($"Starts with C#? {CSharpStartNoSM("C++ Program")}");
    }

    private static bool CSharpStartNoSM(string data)
    {
        string start = "";
        for (int i = 0; i < (data.Length < 2 ? data.Length : 2); i++)
            start += data.Length;
        start = start.Length == 2 ? start : data;
        return start[0] == 'C' && start[1] == '#';
    }
}
