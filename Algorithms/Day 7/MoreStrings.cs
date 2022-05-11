/*
 * Write a C# Sharp program to create a new string using first two characters of a given string.
 * If the string length is less than 2 then return the original string.
 */

using System;

public class MoreStrings
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
        Console.WriteLine($"{GetTwoChar("Da")}");
        Console.WriteLine($"{GetTwoChar("PaPaRaZzI")}");
        Console.WriteLine($"{GetTwoChar("A")}");
        myEvent -= EventData;
    }

    static string GetTwoChar(string data)
    {
        return data.Length > 2 ? data.Substring(0, 2) : data;
    }
}
