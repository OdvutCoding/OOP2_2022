using System;

namespace Lab2Work1
{
    class Program
    {

    }
    class Human
    {
        string name;
        int NID;
        string Nationality;
        string Religion;

        public Human() { }
        public Human(string name)
        {
            this.name = name;
        }
        public Human(string name,  int NID)
        {
            this.name = name;
            this.NID = NID;
        }

        public Human(string name,  int NID, string Nationality)
        {
            this.name = name;
            this.NID = NID;
            this.Nationality = Nationality;
        }

        public Human(string name, int NID, string Nationality, string Religion)
        {
            this.name = name;
            this.NID = NID;
            this.Nationality = Nationality;
            this.Religion = Religion;
        }

        public void showDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("NID: " + NID);
            Console.WriteLine("Nationality: " + Nationality);
            Console.WriteLine("Religion: " + Religion);
        }
        public static void Main(string[] args)
        {
            Human h1 = new Human("Oliver", 656789, "Canadian", "Christian");
            h1.showDetails();
            Console.WriteLine("_________________________________________");
            Human h2 = new Human("John");
            h2.showDetails();
            Console.WriteLine("_________________________________________");
            Human h3= new Human("Crust", 6987, "Christian");
            h3.showDetails();
            Console.WriteLine("_________________________________________");
            Human h4 = new Human("Aristropher", 8888);
            h4.showDetails();

            Console.ReadKey();
        }
    }
}
