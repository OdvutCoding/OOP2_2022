using System;

namespace HelloWorld
{
    class Program
    {
        public static void passByRef(ref int x)
        {
             x = x + 5;
            Console.WriteLine("The value in pass by ref method = " + x);
        }

        static void Main(string[] args)
        {
            // pass by ref
            int y = 5;
            passByRef(ref y);//10
            Console.WriteLine(y);//10
            Console.ReadKey();

        }
    }
}