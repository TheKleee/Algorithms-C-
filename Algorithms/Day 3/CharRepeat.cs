//Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character.

using System;

public class CharRepeat
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Z repeats 2 to 4 times? {ZInRange("zzz")}");
        Console.WriteLine($"Z repeats 2 to 4 times? {ZInRange("Doza")}");
    }

    public static bool ZInRange(string data)
    {
        int zRepet = 0;
        for (int i = 0; i < data.Length; i++)
            zRepet = data[i] == 'z' ? zRepet + 1 : zRepet;

        return zRepet >= 2 && zRepet <= 4;
    }
}
