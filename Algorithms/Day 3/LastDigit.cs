//Write a C# Sharp program to check if two given non-negative integers have the same last digit.

using System;

public class LastDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine($"12 and 322 are both positive and have the same last digit? {SameLastDigit(12, 322)}");
        Console.WriteLine($"-12 and 22 are both positive and have the same last digit? {SameLastDigit(-12, 22)}");
    }

    public static bool SameLastDigit(int x, int y)
    {
        return CheckIfPositive(x, y) && x % 10 == y % 10;
    }

    private static bool CheckIfPositive(int x, int y)
    {
        return x > 0 && y > 0;
    }
}
