//Write a C# Sharp program to remove the character in a given position of a given string.
//The given position will be in the range 0.. string length -1 inclusive.

using System;

public class RemoveStringChar
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test String (c = 2): {RemoveChar(2, "test")}");
        Console.WriteLine($"Test String (c = 3): {RemoveChar(3, "testAS")}");
        Console.WriteLine($"Test String (c = 12):{RemoveChar(12, "testAS")}");
    }

    private static string RemoveChar(int c,string data)
    {
        if (c >= data.Length) c = data.Length - 1; //Making sure that data[c] exists
        string temp = "";
        for (int i = 0; i < data.Length; i++)
            if(i != c) temp += data[i].ToString();
        return temp;
    }
}

//Using the stringName.Remove() method:
public class RemoveString
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Test String (c = 2): {StringRemove(2, "test")}");
        Console.WriteLine($"Test String (c = 3): {StringRemove(3, "testAS")}");
        Console.WriteLine($"Test String (c = 12):{StringRemove(12, "testAS")}");
    }

    private static string StringRemove(int c,string data)
    {
        if (c >= data.Length) c = data.Length - 1;
        return data.Remove(c, 1);
    }
}
