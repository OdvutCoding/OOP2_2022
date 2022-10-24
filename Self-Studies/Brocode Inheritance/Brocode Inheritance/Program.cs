using System;

namespace Brocode_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance = 1 or more child classes who receives fields, methods etc. from a common parent.

            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheels);
            bike.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 20;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bike : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
