//Read-only property using get method only.
using System;

public class ReadDepartment
{
    private string departname;
    public ReadDepartment(string dept)
    {
        departname = dept;
    }
    public string Departname
    {
   //     set 
   //      {
   //         departname = value; 
   //     }
        get
        {
            return departname;
        }
    }
}
public class ReadDepartmain
{
    public static int Main(string[] args)
    {
        ReadDepartment d = new ReadDepartment("Read-Only Dept");
     //   d.Departname = "CSE"; // write
        Console.WriteLine("The Department is: {0}", d.Departname);

        Console.ReadKey();
        return 0;
    }
}
