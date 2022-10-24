using System;

namespace HelloWorld
{
    public class Person 
    {
        public Person() 
        { 
            Console.WriteLine("Parent  class person"); 
        } 
    }
    public class Student : Person 
    { 
        public Student() 
        {
            Console.WriteLine("Child  class student"); 
        } 
    }
    public class BangladeshiStudent : Student 
    { 
        public BangladeshiStudent() 
        { 
            Console.WriteLine("Child  class Bangladeshi student"); 
        } 
    }
    public class IndianStudent : Student 
    { 
        public IndianStudent() 
        { 
            Console.WriteLine("Child  class Indian student"); 
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tripti = new BangladeshiStudent();
            Person shanto = new IndianStudent();
            Console.ReadKey();
        }
    }
}