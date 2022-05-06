//Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.

using System;

public class IntegerRange
{
    static void Main(string[] args)
    {
        Console.WriteLine($"173 or 1995 is in the range of [100.. 200] inclusive? {CheckIntRange(173, 1995)}");
        Console.WriteLine($"22 or 40 is in the range of [100.. 200] inclusive? {CheckIntRange(22, 40)}");
    }

    private static bool CheckIntRange(int i1, int i2)
    {
        return i1 >= 100 && i1 <= 200 || i2 >= 100 && i2 <= 200;
    }
}
