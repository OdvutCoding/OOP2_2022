using System;

namespace Brocode_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = A bundle of related codes.
            //               Can be used as a blueprint for creating objects in object oriented programming.

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }

    static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program");
        }
        public static void Waiting()
        {
            Console.WriteLine("I am waiting for initialization");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye! See you in your next program");
        }
    }
}
