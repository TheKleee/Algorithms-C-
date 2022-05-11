/*
 * Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1.
 */

using System;

public class StringManager
{
    #region Event:
    public delegate void MyEvent();
    public static event MyEvent myEvent;
    
    public static void Main(string[] args)
    {
        myEvent += EventData;
        myEvent?.Invoke();
    }
    #endregion

    /// <summary>
    /// Since I can't get a return type from a delegate I'll just call the desired method within
    /// this subscribed method
    /// </summary>
    private static void EventData()
    {
        Console.WriteLine($"{ConcatAndFlipChain("Da", "Ta")}");
        Console.WriteLine($"{ConcatAndFlipChain("Ta", "Da")}");
        myEvent -= EventData;
    }

    static string ConcatAndFlipChain(string s1, string s2)
    {
        return s1 + s2 + s2 + s1;
    }
}
