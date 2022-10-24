using System;

namespace Brocode_Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overloading = methods that share the same name but different parameters
            // name + parameter = signature of a method
            //methods must have a unique signature

            double total;
            total = Multiply(2, 3, 10);

            Console.WriteLine(total);
            
            total = Multiply(5, 500);

            Console.WriteLine(total); 

            Console.ReadKey();
        }
        static  double Multiply(double a,  double b)
        {
            return a * b;
        }
        static double Multiply(double a,  double b, double c)
        {
            return a * b * c;
        }
    }
}
