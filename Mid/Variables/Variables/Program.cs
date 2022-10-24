using System;

namespace Variables
{
    class Program
    {
        public static string uniName;//class variable, can be called using classname
        public string name; //Instance variable, requires object to call
        //const public static string Nationality = "Bangladeshi";//
        static void Main(string[] args)
        {
            Program.uniName = "American International University of Bangladesh";
            Program s1 = new Program();
          

            Console.ReadKey();
        }
    }
}
