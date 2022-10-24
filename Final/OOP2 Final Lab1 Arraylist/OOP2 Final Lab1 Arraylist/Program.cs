using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(123);
            list.Add("abc");
            list.Add(67);
            list.Add("pqr");
            list.Add(45);
            foreach (object i in list)
            {
                Console.Write(i);
                Console.ReadKey();
            }
        }
    }
}
