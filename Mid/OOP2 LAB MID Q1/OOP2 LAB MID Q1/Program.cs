using System;

namespace OOP2_LAB_MID_Q1
{
    class Program
    {

        static void Main(string[] args)
        {
            AcademicStudent s1 = new AcademicStudent();
            TraineeStudent s2 = new TraineeStudent();

            Console.ReadKey();
        }
    }
    public class Student
    {
        String name;
        String id;
        int initialPayment = 50000;

        public  void ShowStudentinfo(String name, String id)
        {
            this.name = name;
            this.id = id;
        }
    }
    public class AcademicStudent : Student
    {
        public int totalpayacs = 50000 + 36*10000;

      public AcademicStudent()
        {
            Console.WriteLine("Total payment done by Academic Student = " + totalpayacs);
        }
    }
    class TraineeStudent : Student
    {
        public int totalpaytrs = 50000 + 30000;

        public TraineeStudent()
        {
            Console.WriteLine("Total payment done by Trainee Student: = " +totalpaytrs);
        }
    }

}
