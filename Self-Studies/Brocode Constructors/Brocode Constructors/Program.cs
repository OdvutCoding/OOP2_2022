using System;

namespace Brocode_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor = A special method in a class which has the same name as classname. 
            //                                Can be used to assign arguments to fields when creating an object to save time.

            Car car1 = new Car("Koenigsegg", "CCXR", 2011, "Carbon");
            Car car2 = new Car("BMW", "M3 GTR", 2005, "White-Blue Vinyl");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
    class Car
    {
        String brand;
        String model;
        int year;
        String color;

        public Car(String brand, String model, int year, String color)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("Your car details are as follows:");
            Console.WriteLine("Brand name:" + brand);
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Release year:" + year);
            Console.WriteLine("Color:" + color);
            Console.WriteLine();
        }
    }

}
