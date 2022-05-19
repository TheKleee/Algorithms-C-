/*
 * Write a C# Sharp program to create a new list from a given list of integers where each element is multiplied by 3.
 */

using System;
using System.Collections.Generic;
using ListEditor;

#region Area where Junior can change things:
public static class MultiList
{
    public static void Main(string[] args)
    {
        try
        {
            List<int> a1 = new List<int>() { 15, 20, 33 }.MultiplyListElem();
            List<int> a2 = new List<int>() { 13, 3, 12, 33, 77 }.MultiplyListElem();
            List<int> a3 = new List<int>() { 1, 0, 33, 77, 121, 927}.MultiplyListElem();
            ReadList.DisplayMultipleLists(new List<List<int>> { a1, a2, a3 });
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
        #region Int Lists:
        public static List<int> MultiplyListElem(this List<int> l, int multiply = 3)
        {
            if (l == null)
                throw new ArgumentNullException("The given list must contain elements!");

            for (int i = 0; i < l.Count; i++)
                l[i] *= multiply;

            return l;
        }
        #endregion int arrays />
    }

    public static class ReadList
    {
        public static void DisplayList<T>(this List<T> a) where T : struct
        {
            if (a.Count < 1 || a == null)
                throw new ArgumentNullException("The given list must contain at least one element!");

            foreach (var r in a) Console.Write($"{r} ");
            Console.WriteLine("");
        }

        public static void DisplayMultipleLists<T>(this List<List<T>> multiArray) where T : struct
        {
            if (multiArray.Count < 1 || multiArray == null)
                throw new ArgumentNullException("The given jagged list must contain at least one list as an element!");

            foreach (var mA in multiArray)
                mA.DisplayList();
        }
    }
}
#endregion ends here />
