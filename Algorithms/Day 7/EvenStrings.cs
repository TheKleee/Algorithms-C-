/*
 * Write a C# Sharp program to create a new string of the first half of a given string of even length.
 */

using System;

public class EvenStrings
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
        Console.WriteLine($"{HalfString("Da")}");
        Console.WriteLine($"{HalfString("PaPaRaZzI")}");
        Console.WriteLine($"{HalfString("AsdF")}");
        myEvent -= EventData;
    }

    static string HalfString(string data)
    {
        return data.Length % 2 == 0 ? data.Substring(0, data.Length / 2) : "The string length should be an even number!";
    }
}
