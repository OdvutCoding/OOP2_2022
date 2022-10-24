using System;

namespace Brocode_Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();  //'Random' is a class & 'random' is an object of this class. Here we are creating and initializing a new random object

            int num1 = random.Next(1, 7); //'Next' is a method that generates a random 'whole' integer within specified range. Without specified range, this method can generate a random number between 0 and 2 billion.
            // Syntax : object.Next(minimum number, maximum number+1);
            int num2 = random.Next(1, 7) +100; //we can also add additional value to specified range, now it will show a random value between 1 & 106
            int num3 = random.Next(1, 7);

            double num4 = random.NextDouble(); //generates a random decimal number. The random number will be between 0 and 1. 

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.ReadKey();
        }
    }
}
