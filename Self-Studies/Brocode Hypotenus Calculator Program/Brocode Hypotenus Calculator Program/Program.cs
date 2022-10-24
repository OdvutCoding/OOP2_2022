using System;

namespace Brocode_Hypotenus_Calculator_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Side A: "); //user prompt
            double a = Convert.ToDouble(Console.ReadLine()); //user input

            Console.Write("Enter Side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b)); //hypotenuse equation

            Console.WriteLine("The Hypotenuse of the tringle is: " + c); //hypotenuse output


            Console.ReadKey();
        }
    }
}
