/*
 * Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
 */

using System;

public class SequenceOTT
{
    static void Main(string[] args)
    {
        ;
        Console.WriteLine($"{ContainsSequence(new[] { 1, 2, 3, 4, 5 })}");
        Console.WriteLine($"{ContainsSequence(new[] { 2, 3, 4, 1, 7 })}");
    }
    public static bool ContainsSequence(int[] intArr)
    {
        for (int i = 0; i < intArr.Length - 3; i++)
            if (intArr[i] == 1 && intArr[i + 1] == 2 && intArr[i + 2] == 3)
                return true;

        return false;
    }
}
