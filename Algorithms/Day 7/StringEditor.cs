/*
 * Write a C# Sharp program to insert a given string into middle of the another given string of length 4.
 */

using System;

public class StringEditor
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
        Console.WriteLine($"{InsertString("Da", "TaPa")}");
        Console.WriteLine($"{InsertString("Ta", "DaPa")}");
        myEvent -= EventData;
    }

    static string InsertString(string s1, string s2)
    {
        //In this case s2.Length is 4 so we could use 2 instead of the Substring() method, however this is less hardcoded!!!
        return s2.Substring(0, s2.Length / 2) + s1 + s2.Substring(s2.Length / 2);   
    }
}
