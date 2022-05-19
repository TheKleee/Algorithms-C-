/*
 * Write a C# Sharp program to create a new list from a given list of strings where each element has
 * "#" added at the beginning and end position.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using ListEditor;

#region Area where Junior can change things:
public static class HashList
{
    public static void Main(string[] args)
    {
        try
        {
            List<string> s1 = new List<string>() { "1", "2", "3" }.NestElemInHash();
            List<string> s2 = new List<string>() { "z", "x", "c" }.NestElemInHash();
            List<string> s3 = new List<string>() { "!", "@", "#" }.NestElemInHash();
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
        public static List<string> NestElemInHash(this List<string> l)
        {
            if (l == null)
                throw new ArgumentNullException("The given list must contain elements!");

            IEnumerable<string> s = l.Select(x => "#" + x + "#");
            return s.ToList();
        }
        #endregion string lists />
    }

    public static class ReadList
    {
        #region String List:
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
        #endregion string list />
    }
}
#endregion ends here />
