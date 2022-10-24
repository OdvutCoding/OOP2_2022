using System;

namespace OOPL3T2
{
    class Program
    {

        public enum Months 
        { 
            January = 1,  February,  March,  April,  May,  June,  July,  August,  September, October , November, December
        };
        static void Main(string[] args)
        {
            //Console.WriteLine(Months.October);
            Console.WriteLine("Month {0} of the year : {1} ", (int) Months.January, Months.January);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.February, Months.February);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.March, Months.March);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.April, Months.April);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.May, Months.May);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.June, Months.June);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.July, Months.July);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.August, Months.August);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.September, Months.September);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.October, Months.October);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.November, Months.November);
            Console.WriteLine("Month {0} of the year : {1} ", (int)Months.December, Months.December);


            Console.ReadKey();
        }
    }
}
