using System;

public class DataIfString
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Data starts with if: {IfString("iffy")}");
        Console.WriteLine($"Data doesn't start with if: {IfString("fly")}");
    }

    private static string IfString(string data)
    {
        if (data[0] == 'i' && data[1] == 'f') return data;
        return $"if{data}";
    }
}

public class DataIfStringSubstring
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Data starts with if: {IfStringSubstring("iffy")}");
        Console.WriteLine($"Data doesn't start with if: {IfStringSubstring("fly")}");
    }

    private static string IfStringSubstring(string data)
    {
        if (data.Substring(0, 2).Equals("if")) return data;
        return $"if{data}";
    }
}
