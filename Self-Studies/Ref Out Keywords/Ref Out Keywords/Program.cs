//using System.IO;
using System;
public class Program
{
    public static void update(out int a)
    {
        a = 10;
    }
    public static void change(ref int d)
    {
        d = 11;
    }
    public static void Main()
    {
        int b; //b's value will be updated by a using out b. || b only needs to be Declared as it's being called by out keyword. 
        int c = 9; //c's value will be updated by d using ref c || C must be be assigned here due to being called by ref keyword. Declaration + Initialization is mandatory
       // Program p1 = new Program();
        update(out b);//
        change(ref c);//
        Console.WriteLine("Updated value is: {0}", b);//10
        Console.WriteLine("Changed value is: {0}", c);//11
        Console.ReadKey();
    }
}