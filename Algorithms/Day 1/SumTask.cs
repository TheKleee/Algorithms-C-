//Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.

public class SumTask
{
    public static void Main()
    {
        System.Console.WriteLine($"Sum of 3 and 4 is: " + SumOrTriple(3, 4));
        System.Console.WriteLine($"Sum of 12 and 12 is not: " + SumOrTriple(12, 12));
    }
    
    public static int SumOrTriple(int x, int y)
    {
        return x != y ? x + y : (x+ y) * 3;
    }
}
