//Encapsulation using property
using System;

public class Department
{
    private string departname;
    public string Departname
    {
        get
        {
            return departname;
        }
        set
        {
            departname = value;
        }
    }
}

public class Departmentmain
{
    public static void Main(string[] args)
    {
        Department d = new Department();
        d.Departname = "Communication"; // write
        Console.WriteLine("The Department is :{0}", d.Departname);
        Console.ReadKey();

    }
}