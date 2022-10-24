using System;

namespace PropertyDeclaration
{
    class Program
    {
        private int id,  age; //initialized variables
        public int ID { set   //ID property definition & initialization 
            {
                if (value > 0) //Condition setting to omit negative integers 
                {
                    id = value;
                }
                else { Console.WriteLine("Invalid ID"); //Output in case of incorrect data type set as ID
                }
            } 
            get 
            {
                return this.id; //the usual this.this
            }
        }

        public int Age //Age property definition & initialization
        {
            set
            {
                if (value > 0) //Age cannot be a negative 
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid Age"); //Output in case of negative age or invalid age ex: Sixty Nine instead of 69
                }
            }
            get
            {
                return this.age; //the usual
            }
        }
        static void Main(string[] args)
        {
            Program s1 = new Program();
            Program s2 = new Program();
            s1.ID = 2222;
            s1.Age = 20;
            s2.ID = 3333;
            s2.Age = 19;
            Console.WriteLine("ID : {0} & Age: {1}", s1.ID, s1.Age);
            Console.WriteLine("ID : {0} & Age: {1}", s2.ID, s2.Age);
            Console.ReadKey();
        }
    }
}
