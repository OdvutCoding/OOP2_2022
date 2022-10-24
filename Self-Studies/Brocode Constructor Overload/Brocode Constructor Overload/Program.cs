using System;

namespace Brocode_Constructor_Overload
{
    class Program
    {

        static void Main(string[] args)
        {
            //overloaded constructors = technique to create multiple constructors with same name,
            //                                                  but with different set of parameters
            //                                                  name + parameter = signature

            Pizza pizza1 = new Pizza("Stuffed Crust", "Read Sauce", "Mozzarella", "Chicken slices");
            Pizza pizza2 = new Pizza("Stuffed Crust", "Read Sauce", "Mozzarella");
            Pizza pizza3 = new Pizza("Stuffed Crust", "Read Sauce");

            pizza1.Menu();
            pizza2.Menu();
            pizza3.Menu();
           
            Console.ReadKey();
        }
    }

     class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String toppings;

        public Pizza(String bread, String sauce, String cheese, String toppings)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.toppings = toppings;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public  void Menu()
        {
            Console.WriteLine("Your pizza has the following: ");
            Console.WriteLine("Bread : " + bread);
            Console.WriteLine("Sauce : " + sauce);
            Console.WriteLine("Cheese : " + cheese);
            Console.WriteLine("Toppings : " + toppings);
            Console.WriteLine();
        }
    }
}
