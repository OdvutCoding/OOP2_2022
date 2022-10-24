using System;

namespace Brocode_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism = means to "have many forms"
            //                                Objects can be identified by more than one type
            //                                Example: A dog can be identified as: Animal, Canine, Organism etc.

            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

            Vehicle[] vehicles = {  car, bike, boat  };

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.go();
            }

            Console.ReadKey();
        }
    }
    class Vehicle //Parent class
    {
        public virtual void go()
        {

        }
    }
    class Car : Vehicle //Child class
    {
        public override void go()
        {
            Console.WriteLine("Car is moving!");
        }
    }
    class Bike : Vehicle//Child class
    {
        public override void go()
        {
            Console.WriteLine("Bike is moving!");
        }
    }
    class Boat : Vehicle//Child class
    {
        public override void go()
        {
            Console.WriteLine("Boat is moving!");
        }
    }
}

