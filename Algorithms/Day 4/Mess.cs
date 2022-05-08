/*
 * Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
 *  a ab abc abcd
 */

using System;

//Without String Methods:
public class Mess
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Calculated mess from abcd: {CalculatedMess("abcd")}");
        Console.WriteLine($"Calculated mess from qwerty: {CalculatedMess("qwerty")}");
    }
    public static string CalculatedMess(string data)
    {
        string mess = "";
        for (int i = 0; i < data.Length; i++)
            for (int j = 0; j <= i; j++)
                mess += data[j];
       
        return mess;
    }
}

//With String Methods:
public class MessSM
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Calculated mess from abcd: {CalculatedMessSM("abcd")}");
        Console.WriteLine($"Calculated mess from qwerty: {CalculatedMessSM("qwerty")}");
    }
    public static string CalculatedMessSM(string data)
    {
        string messSM = "";
        for (int i = 0; i < data.Length; i++)
                messSM += data.Substring(0, i + 1);
       
        return messSM;
    }
}
