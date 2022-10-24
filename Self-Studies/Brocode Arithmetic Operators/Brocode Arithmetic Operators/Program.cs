using System;

namespace Brocode_Arithmetic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;

            //friends = friends + 1;  //does regular addition, adds 1, this is the standard way
            //friends += 1; //does the same  thing as above command but using a shorter command sequence, used as shortcut
            friends++; //does the same thing as above two while using an even shorter sequence, used for loops

            int mutual = 8;

            //mutual = mutual - 1; //the standard substraction method, substracts 1
            //mutual -= 1; //does the same  thing as above command but using a shorter command sequence, used as shortcut
            mutual--; //does the same thing as above two while using an even shorter sequence, used for loops

            int quack = 6; 

            //quack = quack * 2; //the standard multiplication method
            quack *= 2; //does the same  thing as above command but using a shorter command sequence, used as shortcut
            
            double diva = 5;

            //diva = diva / 2; //the standard division method
            diva /= 2; //does the same  thing as above command but using a shorter command sequence, used as shortcut

            int number = 40;
            int remainder = number % 3; //the standard modulus or remainder fuction
            // if divisible fully, the output will be 0, which also shows it's an even number. Otherwise there will be remainder and the number will be odd. 
            

            Console.WriteLine(friends);
            Console.WriteLine(mutual);
            Console.WriteLine(quack);
            Console.WriteLine(diva);
            Console.WriteLine(remainder);
            Console.ReadKey();
        }
    }
}
