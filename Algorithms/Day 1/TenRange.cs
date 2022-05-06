//Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
using System;

public class TenRangeMath
{
    public static void Main(string[] args)
    {
        Console.WriteLine("3 is in the range? " + RangeCheckMath(3));
        Console.WriteLine("92 is in the range? " + RangeCheckMath(92));
        Console.WriteLine("201 is in the range? " + RangeCheckMath(200));
    }
    
    public static bool RangeCheckMath(int x)
    {
        if (Math.Abs(100 - x) <= 10 || Math.Abs(200 - x) <= 10) return true;
        return false;
    }
}

//Without namespace directives (mainly not using Math):
public class TenRange
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("3 is in the range? " + RangeCheck(3));
        System.Console.WriteLine("92 is in the range? " + RangeCheck(92));
        System.Console.WriteLine("201 is in the range? " + RangeCheck(200));
    }
    
    public static bool RangeCheck(int x)
    {
        if(x <= 100 && 100 - x <= 10 || x >= 100 && x - 100 <= 10) return true;
        else if(x <= 200 && 200 - x <= 10 || x >= 200 && x - 200 <= 10) return true;
        return false;
    }
}

