//Write a C# Sharp program to check if one given temperature is less than 0 and the other is greater than 100. 

using System;

public class Temperature
{
    static void Main(string[] args)
    {
        Console.WriteLine($"-15C, 120C one is less than 0 and other is greater than 100? {CheckTemperatureRange(-15, 120)}");
        Console.WriteLine($"100.5C, 12C one is less than 0 and other is greater than 100? {CheckTemperatureRange(100.5f, 12)}");
        Console.WriteLine($"36C, -102C one is less than 0 and other is greater than 100? {CheckTemperatureRange(36, -102)}");
    }

    private static bool CheckTemperatureRange(float t1, float t2)
    {
        return t1 < 0 && t2 > 100 || t1 > 100 && t2 < 0;
    }
}
