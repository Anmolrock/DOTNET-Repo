using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Grandfather
    {

        public void show1()
        {
            Console.WriteLine("This is a GrandFather Class");
        }
    }
    interface father
    {
         void show2();
    }

    class child:Grandfather,father
    {
        public void show2()
        {
            Console.WriteLine("This is a Father Class");
        }
        static void Main(string[] args)
        {
            int x = 10;
            child obj = new child();
            obj.show1();
            obj.show2();
            Console.WriteLine("This is a Child Class {0}",x+x);
            Console.ReadLine();
         
        }
    }
}
