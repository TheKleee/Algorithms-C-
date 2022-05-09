/*
 * Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.
 */

using System;

public class GetFive
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{FiveCheck(2, 3)}");
        Console.WriteLine($"{FiveCheck(5, 3)}");
        Console.WriteLine($"{FiveCheck(8, 3)}");
        Console.WriteLine($"{FiveCheck(12, 2)}");
    }
    public static bool FiveCheck(int x, int y)
    {
        return x + y == 5 || x == 5 || y == 5 || x - y == 5 || y - x == 5;
    }
}

//With Math methods
public class GetFiveMath
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{FiveCheckMath(2, 3)}");
        Console.WriteLine($"{FiveCheckMath(5, 3)}");
        Console.WriteLine($"{FiveCheckMath(8, 3)}");
        Console.WriteLine($"{FiveCheckMath(12, 2)}");
    }
    public static bool FiveCheckMath(int x, int y)
    {
        return x + y == 5 || x == 5 || y == 5 || Math.Abs(x - y) == 5;
    }
}
