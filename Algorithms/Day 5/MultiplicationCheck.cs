/*
 * Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.
 */

using System;

//With Math methods
public class MultiplicationCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{MultipleOfThreeOrSeven(14)}");
        Console.WriteLine($"{MultipleOfThreeOrSeven(21)}");
        Console.WriteLine($"{MultipleOfThreeOrSeven(5)}");
        Console.WriteLine($"{MultipleOfThreeOrSeven(9)}");
    }
    public static bool MultipleOfThreeOrSeven(int x)
    {
        if (x % 3 == 0 && x % 7 == 0)
            return false;
        else
            return x % 3 == 0 || x % 7 == 0;
    }
}
