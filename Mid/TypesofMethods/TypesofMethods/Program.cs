using System;

namespace TypesofMethods
{
    class Program
    {
        public static void  print1()
        {
            Console.WriteLine("I am a static method."); //Requires classname to be called if in a different class. Under same class, can be called without class name.
        }

        public void print2()
        {
            Console.WriteLine("I am an instance method, I require an object to be called."); //Requires object to be called.
        }
        static void Main(string[] args)
        {
            print1(); // can be called with our without classname if under same class
            Program n2 = new Program();
            n2.print2();

            Console.ReadKey();
        }
    }
}
