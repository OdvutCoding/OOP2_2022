using System;

namespace Constants
{
    class Example
    {
        int x; //Non-static variable
        static int y = 200; //Static Variable
        const float PI = 3.14f; //Const Variable
        readonly bool flag; //Readonly Variable
        public Example(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Example.y);
            Console.WriteLine(Example.PI);
            //Console.WriteLine(x); //Object required due to being non static
            Example obj1 = new Example(50, true);
            Example obj2 = new Example(100, false);
            Console.WriteLine(obj1.x + " " + obj2.x);
            Console.WriteLine(obj2.flag + " " + obj1.flag);
            Console.WriteLine("Press any key to exit.");
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
