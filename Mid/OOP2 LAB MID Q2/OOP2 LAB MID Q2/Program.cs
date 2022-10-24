using System;

namespace OOP2_LAB_MID_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
    class XYZEmployee
    {
        private String name;
        private readonly String eid;
        private readonly int salary;

        public XYZEmployee(String eid, int salary)
        {
            this.eid = eid;
            this.salary = salary;
        }

        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return this.name;
            }
        }

        public  String Eid { get; }
        public  int Salary { get; }


    }
}
