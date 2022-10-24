using System;

namespace Brocode_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //method = performs a section of code, whenever it is called "invoked"
            // benefit of using method is  that we can reuse the code without writing it multiple times.

            //Let's say we need to say Happy birthday to someone 3 times, we can do so using a method instead of using writeline command multiple times

            string name = "Jesse";
            int age = 20;

            wishHappyBirthday(name, age);
           

            Console.ReadKey();
        }
        //method needs to be declared outside of main function and must match the type of Main function. Here it's "static" since our main function is also static. 
        static void wishHappyBirthday(string Birthdayboy, int yearsold) //parameter name can be different but parameter data type must be in exact order as defined inside method call inside main function; eg: line 17
        {
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine("Happy Birthday dear " +Birthdayboy);
            Console.WriteLine("Happy birthday on your " + yearsold + "th Birthday");
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine();
        }
    }
}
