//Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive,
//or return 0 if neither is in that range.

using System;

public class ValueRange
{
    static void Main(string[] args)
    {
        Console.WriteLine($"If not in range [20..30] return 0 else between 23 and 27 the larger is: {LargerValueInRange(23, 27)}");
        Console.WriteLine($"If not in range [20..30] return 0 else between 52 and 27 the larger is: {LargerValueInRange(52, 27)}");
    }

    public static int LargerValueInRange(int x, int y)
    {
        if(x >= 20 && x <= 30 && y >= 20 && y <= 30)
            return x > y ? x : y;
        return 0;
    }
}
