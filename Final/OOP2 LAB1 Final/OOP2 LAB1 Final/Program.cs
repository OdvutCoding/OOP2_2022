using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class MyArray
{
    public static void Main()
    {
        int[] numarray = new int[3];
        numarray[0] = 10;
        numarray[1] = 20;
        numarray[2] = 30;

        numarray[3] = 40; //Will cause exception due to array size upto 3 in new int[3]
       numarray[4] = 50;
        foreach (int num in numarray)
        {
            Console.Write(num);
            Console.ReadKey();
        }
    }
}

