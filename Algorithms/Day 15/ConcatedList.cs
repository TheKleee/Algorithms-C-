/*
 * Write a C# Sharp program to create a new list from a given list of strings
 * where each element is replaced by 4 copies of the string concatenated together.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using ListEditor;

#region Area where Junior can change things:
public static class ConcatedList
{
    public static void Main(string[] args)
    {
        try
        {
            List<string> s1 = new List<string>() { "1", "2", "3" }.SetConcatedList();
            List<string> s2 = new List<string>() { "z", "x", "c" }.SetConcatedList();
            List<string> s3 = new List<string>() { "!", "@", "#" }.SetConcatedList();
            ReadList.DisplayMultipleLists(new List<List<string>> { s1, s2, s3 });
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}\n{e.StackTrace}");
        }
    }
}
#endregion junior's influence ends here />


#region Junior can't touch this:
namespace ListEditor
{
    public static class ReturnList
    {
        #region String Lists:
        public static List<string> SetConcatedList(this List<string> l, int concateTimes = 4)
        {
            if (l == null)
                throw new ArgumentNullException("The given list must contain elements!");

            IEnumerable<string> s = l.Select(x => x.ConcatTimes(concateTimes));
            return s.ToList();
        }

        public static string ConcatTimes(this string st, int times)
        {
            string copy = st;
            for (int j = 1; j < times; j++)
                st += copy;

            return st;
        }
        #endregion string lists />
    }

    public static class ReadList
    {
        public static void DisplayList<T>(this List<T> l)
        {
            if (l.Count < 1 || l == null)
                throw new ArgumentNullException("The given list must contain at least one element!");

            foreach (var r in l) Console.Write($"{r} ");
            Console.WriteLine("");
        }

        public static void DisplayMultipleLists<T>(this List<List<T>> multiList)
        {
            if (multiList.Count < 1 || multiList == null)
                throw new ArgumentNullException("The given jagged list must contain at least one list as an element!");

            foreach (var mA in multiList)
                mA.DisplayList();
        }
    }
}
#endregion ends here />
