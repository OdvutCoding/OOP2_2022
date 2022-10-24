using System;

namespace Constructor_Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentEmployee e1 = new ParentEmployee("Karim", 55, "Dhaka");
            e1.display();
            Console.ReadKey();
        }
    }
    internal class ChildEmployee
    {
        public ChildEmployee()
        {
            Console.WriteLine("Employee: ");
        }
        public ChildEmployee(int number)//4th call
        {
            Console.WriteLine("Employee number: " +number);
        }
        public ChildEmployee(string name, int number) : this(number)//3rd call
        {
            Console.WriteLine("Employee name : " +name);
        }
        public ChildEmployee(string name, int number,string branch) : this(name,number)//2nd call
        {
            Console.WriteLine("Employee branch : " +branch);
        }
        public virtual void display()
        {
            Console.WriteLine("Child Employee display");
        }
    }
    internal class ParentEmployee : ChildEmployee
    {
        public ParentEmployee()
        {
            Console.WriteLine("Parent Employee");
        }
        public ParentEmployee(string name, int number, string branch) : base(name, number, branch)//1st call
        {
            Console.WriteLine("Parent Employee");
        }
        public ParentEmployee(string name, int number, string branch, int age) : base(name, number, branch)
        {
            Console.WriteLine("Employee age :" + age);
        }
        public override void display() //5th call
        {
            Console.WriteLine("Parent Employee Display");
        }
    }
}
