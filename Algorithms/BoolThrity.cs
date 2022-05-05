//Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

public class BoolThrity
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("3 + 27 is 30? " + ThirtyCheck(3, 27));
        System.Console.WriteLine("Either 35 or 30 is actually 30? " + ThirtyCheck(35, 30));
        System.Console.WriteLine("3 + 35 is 30? " + ThirtyCheck(3, 35));
    }
    
    public static bool ThirtyCheck(int x, int y)
    {
        if(x == 30 || y == 30) return true;
        return x + y == 30 ? true : false;
    }

}

//Simplified:  
public class BoolThirtySimple
{
     public static void Main(string[] args)
     {
        System.Console.WriteLine("3 + 27 is 30? " + ThirtyCheckSimplified(3, 27));
        System.Console.WriteLine("Either 35 or 30 is actually 30? " + ThirtyCheckSimplified(35, 30));
        System.Console.WriteLine("3 + 35 is 30? " + ThirtyCheckSimplified(3, 35));
     }

    public static bool ThirtyCheckSimplified(int x, int y)
    {
        return x == 30 || y == 30 || x + y == 30;
    }
}
