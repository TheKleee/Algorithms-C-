/*
 * Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13.
 */

using System;

public class GetThirteen
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{ThirteenCheck(1)}");
        Console.WriteLine($"{ThirteenCheck(14)}");
        Console.WriteLine($"{ThirteenCheck(25)}");
        Console.WriteLine($"{ThirteenCheck(26)}");
    }
    
    public static bool ThirteenCheck(int x)
    {
        return x > 1 ? x % 13 == 0 || x % 13 == 1 : false;
    }
}

public class GetThirteenGeneric
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{ThirteenCheckGeneric<bool>(1)}");
        Console.WriteLine($"{ThirteenCheckGeneric<bool>(13)}");
        Console.WriteLine($"{ThirteenCheckGeneric<bool>(27)}");
    }
    public static T ThirteenCheckGeneric<T>(int x) where T: struct
    {
            return (T) Convert.ChangeType(x > 1 ? x % 13 == 0 || x % 13 == 1 : false, typeof(T));
    }
}
