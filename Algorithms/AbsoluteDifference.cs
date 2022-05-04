//Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.

using System;

public class AbsoluteDifference
{
    public static void Main()
    {
        System.Console.WriteLine("Absolute difference of 3 and 51 is: " + AbsoluteDifference(3));
        System.Console.WriteLine("Absolute difference of 57 and 51 is not: " + AbsoluteDifference(57));
    }
    
    public static int AbsoluteDifference(int n)
    {
        return n > 51 ? 3 * Math.Abs(n - 51) : Math.Abs(n - 51);
    }
}
