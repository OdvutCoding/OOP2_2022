using System;
public class WriteDepartment
{
    private string departname;
    public string Departname
    {
        set
        {
            departname = value;
           Console.WriteLine("The Department is :{0}", departname);
        }
    }
}
public class WriteDepartmain
{
    public static int Main(string[] args)
    {
        WriteDepartment d = new WriteDepartment();
        d.Departname = "COMPUTERSCIENCE";
        return 0;
    }
}