/*
 * Write a C# Sharp program to create a new string using three copies of the last two character of a given string
 * of length atleast two.
 */

using System;

public class StringProgram
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
        Console.WriteLine($"{TwoCharXThree("Da")}");
        Console.WriteLine($"{TwoCharXThree("DaPa")}");
        Console.WriteLine($"{TwoCharXThree("")}");
        myEvent -= EventData;
    }

    static string TwoCharXThree(string data)
    {
        string s = data.Length >= 2 ? data.Substring(data.Length - 2) : "";
        return s.Length > 0 ? s + s + s : "The string provided must be at least 2 characters long!"; ;  
    }
}
