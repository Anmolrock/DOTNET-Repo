using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public int a , b ;
        public void getdata(int x, int y)
        {
            a = x;
            b = y;
        }
    }
    class Derived:Class1
    {
        public void Showdata()
        {
            Console.WriteLine("The Addition of A And B is:\t" +  (a + b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Derived d = new Derived();
            Console.WriteLine("Enter First Number");
            x=Int32.Parse( Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            y = Int32.Parse(Console.ReadLine());
            d.getdata(x,y);
            d.Showdata();
            Console.ReadLine();
        }
    }
}
