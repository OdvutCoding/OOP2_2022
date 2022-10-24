using System;

namespace Brocode_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //static = a modifier to declare a static member, which belongs to class itself rather than to any object.

            //let's say we have 2 cars and we will have a race. We need to keep track of how many cars are instantiated/created for entering the race. We can do so using "static" modifier.
            Car car1 = new Car("Koenigsegg");
            Car car2 = new Car("Maserati");
            Car car3 = new Car("Lamborghini");

            //Console.WriteLine(car1.numberofCars); //incorect non static way
            
            Console.WriteLine(Car.numberofCars); //correct static way

            Car.Startrace();

            Console.ReadKey();
        }
    }

    class Car
    {
        String model;
        public static int numberofCars;
        public Car(String model)
        {
            this.model = model;
            numberofCars++;
        }
        public static void Startrace()
        {
            Console.WriteLine("The race has begun!");
        }

    }
}
