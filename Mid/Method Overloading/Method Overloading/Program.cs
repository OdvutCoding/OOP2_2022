using System;
namespace HelloWorld
{
    class Addition
    {
        internal void sum() { Console.WriteLine(100 + 200); }
        internal void sum(int a) { Console.WriteLine(a + 200); }
        internal void sum(int a, int b) { Console.WriteLine(a + b); }
        internal void sum(int a, float b) { Console.WriteLine(a + b); }
        internal void sum(float a, int b) { Console.WriteLine(a + b); }
        internal void sum(double a, double b) { Console.WriteLine(a + b); }
        internal void sum(double a, double b, double c) { Console.WriteLine(a + b + c); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Addition ob1 = new Addition();
            ob1.sum();
            ob1.sum(500.0, 5000.0);
            ob1.sum(1000, 10000);
            Console.ReadKey();
        }
    }
}