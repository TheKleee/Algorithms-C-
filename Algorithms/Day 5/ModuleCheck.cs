/*
 * Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.
 */

using System;

public class ModuleCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{ModuleTenRangeTwo(100)}");
        Console.WriteLine($"{ModuleTenRangeTwo(21)}");
        Console.WriteLine($"{ModuleTenRangeTwo(52)}");
        Console.WriteLine($"{ModuleTenRangeTwo(7)}");
    }
    public static bool ModuleTenRangeTwo(int x)
    {
        return x % 10 <= 2 || x % 10 >= 8;
    }
}
