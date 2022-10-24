using System;

namespace Brocode_Math_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = -10;
            double z = 6.69;

            double a = Math.Pow(x, 2); //raises the power of a number. 'Math' is a class here, 'Pow' is power function of Math class. Syntax : Math.Pow(number, power);
            double b = Math.Sqrt(x); //finds the square root of a number. Syntax : Math.Sqrt(number);
            double c = Math.Abs(y); //finds the absolute value of a number. Syntax : Math.Abs(number);
            double d = Math.Round(z); //rounds up a number. Syntax : Math.Round(number); It uses the regular sense of decimal point. Higher ceiling if > .5, lower ceiling if < .5
            double e = Math.Ceiling(z);//rounds up a number while considering upper ceiling. Syntax : Math.Ceiling(number). This will output 4
            double f = Math.Floor(z);//rounds up a number while considering lower ceiling. Syntax : Math.Floor(number). This will output 3
            double g = Math.Max(x, y);//finds the maximum between two numbers & outputs the maximum value. Syntax : Math.Max(number1, number 2.....number n);
            double h = Math.Min(x, y);//finds the minimum between two numbers & outputs the minimum value. Syntax : Math.Min(number1, number 2.....number n);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
          
            Console.ReadKey();
        }
    }
}
