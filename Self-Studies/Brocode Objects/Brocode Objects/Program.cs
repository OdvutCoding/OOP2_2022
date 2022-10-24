using System;

namespace Brocode_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //object = It is an instance of a class
            //                   Classes can be used as blueprint to create objects in OOP
            //                   Objects can have fields and methods (chearacteristics & actions)
            Human h1 = new Human();
            Human h2 = new Human();

            h1.name = "Rick";
            h1.age = 65;

            h2.name = "Morty";
            h2.age = 18;

            h1.eat();
            h1.sleep();

            h2.eat();
            h2.sleep();

            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public void eat()
        {
            Console.WriteLine(name + " is eating");
        }
         public void sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }

}
