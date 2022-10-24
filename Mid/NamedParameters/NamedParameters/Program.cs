using System;

namespace NamedParameters
{
    class Program
    {
        void Fullname(string fn, string ln, string nat = " American") //Nationality here is default paremeter while others are named parameters
        {
            Console.WriteLine(fn + ln + nat);
            Console.WriteLine(ln + fn + nat);
        }
  
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            Program s1 = new Program();
            s1.Fullname(fn: " Oliver", ln: " Jess");
            Program s2 = new Program();
            s2.Fullname(fn: " Md Tofique", ln: " Rahman");


            Console.ReadKey();
        }
    }
}
