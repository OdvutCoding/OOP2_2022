using System;

namespace Ineritance_Test
{
     public  class Person
    {
        public Person()
        {
            Console.WriteLine("Parent class person");
        }
    }
    public class Student : Person
    {
        public Student()
        {
            Console.WriteLine("Child class");
        }
    }
    public class BangladeshiStudent : Student
    {
        public BangladeshiStudent()
        {
            Console.WriteLine("Bangladeshi Student");
        }
    }
    public class IndianStudent : Student
    {
        public IndianStudent()
        {
            Console.WriteLine("Indian Student");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person s1 = new BangladeshiStudent();
            Person s2 = new IndianStudent();
            Console.ReadKey();
        }
    }
}
