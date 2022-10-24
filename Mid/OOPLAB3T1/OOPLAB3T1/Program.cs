using System;

namespace OOPLAB3T1
{
    struct Program
    {

    }
    struct Student
    {
        string name;
        int ID;
        float cg;

        public Student(string name, int ID, float cg)
        {
            this.name = name;
            this.ID = ID;
            this.cg = cg;
        }


        public void showDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("CGPA: " + cg);
        }
        public static void Main(string[] args)
        {
            Student s1 = new Student("Oliver", 123, 3.75f);
            s1.showDetails();

            Console.ReadKey();
        }
    }
}

