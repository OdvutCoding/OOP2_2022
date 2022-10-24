using System;

namespace HelloWorld
{
    internal class A
    {
        internal int a = 5;
        internal virtual void print() { Console.WriteLine("class A in parent"); }
        internal void show() { Console.WriteLine("show method"); }
    }
    internal class B : A
    {

        internal override void print() { Console.WriteLine("class B in child"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A ob1 = new A();
            ob1.print();

            B ob2 = new B();
            ob2.print();
            ob2.show();
            //ob2.a = 123;
            Console.ReadKey();
        }
    }
}

