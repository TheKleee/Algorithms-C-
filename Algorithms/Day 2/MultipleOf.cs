//Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.

using System;

public class MultipleOf
{
    static void Main(string[] args)
    {
        Console.WriteLine($"21 is multiple of 3 or 7? {MultipleCheck(21)}");
        Console.WriteLine($"42 is multiple of 3 or 7? {MultipleCheck(42)}");
        Console.WriteLine($"82 is multiple of 3 or 7? {MultipleCheck(82)}");
    }

    private static bool MultipleCheck(int n)
    {
        return n % 3 == 0 || n % 7 == 0;
    }
}
