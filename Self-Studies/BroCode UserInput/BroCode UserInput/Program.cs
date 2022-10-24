using System;

namespace BroCode_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            String name = Console.ReadLine(); //'Readline' is the method for taking user input, we will store it inside the 'name' variable. 

            Console.WriteLine("What's your age? (use numbers)");
            int  age = Convert.ToInt32(Console.ReadLine()); //Here we had to 'typecast' to integer using 'Convert.ToInt32()' method since 'Readline' reads characters from user input & we are storing that age input as integers.
                                                                                                  //if user inputs anything but number here, the program will be interrupted with unhandled exception due to wrong input format. Future lecture will cover this area. 

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are "  +  age  +  " years old");

            Console.ReadKey();


        }
    }
}
