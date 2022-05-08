/*
 * Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string.
 * Do not count the end substring.
 */

using System;

public class StringCounter
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Contains two chars from abcdababab and end with same two chars (ignored in count): abcdababab" +
            $" {TimesTwoCharRepeatInString("abcdababab")}");
        Console.WriteLine($"Contains two chars from abcdababab and end with same two chars (ignored in count) qwertyqwasd:" +
            $": {TimesTwoCharRepeatInString("qwertyqwasd")}");
        Console.WriteLine($"Contains two chars from abcdababab and end with same two chars (ignored in count) qwertqw:" +
            $": {TimesTwoCharRepeatInString("qwertqw")}");
    }
    public static int TimesTwoCharRepeatInString(string data)
    {
        string twoChars = data.Substring(data.Length - 2);
        if (data.EndsWith(twoChars))
        {
            string dataClone = data.Substring(0, data.Length - 2);
            int times = 0;
            for (int i = 1; i < dataClone.Length; i++)
                if (twoChars[0] == dataClone[i - 1] && twoChars[1] == dataClone[i])
                    times++;

            return times;
        }
        return 0;
    }
}

public class StringCounterSimplified
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Contains two chars from abcdababab and end with same two chars (ignored in count): abcdababab" +
            $" {TimesTwoCharRepeatInStringSimplified("abcdababab")}");
        Console.WriteLine($"Contains two chars from abcdababab and end with same two chars (ignored in count) qwertyqwasd:" +
            $": {TimesTwoCharRepeatInStringSimplified("qwertyqwasd")}");
        Console.WriteLine($"Contains two chars from abcdababab and end with same two chars (ignored in count) qwertqw:" +
            $": {TimesTwoCharRepeatInStringSimplified("qwertqw")}");
    }
    public static int TimesTwoCharRepeatInStringSimplified(string data)
    {
        int count = 0;
        string lastTwoChar = data.Substring(data.Length - 2);
        for (int i = 0; i < data.Length - 2; i++)
            if (data.Substring(i, 2).Equals(lastTwoChar)) count++;
        return count;
    }
}
