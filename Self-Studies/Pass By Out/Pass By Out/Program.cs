using System;

namespace PassbyOut

{
    class program
    {
        public static void passbyout(out int x)
        {
            x = 110;
            x = x + 5;
            Console.WriteLine("The value in pass by out method = " + x);
        }


        public static void Main(string[] args)
        {
            // pass by out
            int y;
            passbyout(out y);
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
