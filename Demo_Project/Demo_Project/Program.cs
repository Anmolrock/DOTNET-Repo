using System;
using System.Collections;
interface abc
{
    public void disp();
}

interface ghi
{
    public void display();
}
class main : abc, ghi
{
    public static void Main (string[] args)
    {
        main obj = new main ();
        obj.display ();
        obj.disp();

        Console.WriteLine("Hello Anmol Upadhyay");
    }
    public void display()
    {
        Console.WriteLine("This is Class ghi");
    }

    public void disp()
    {
        Console.WriteLine("This is Class Abc");
    }
}