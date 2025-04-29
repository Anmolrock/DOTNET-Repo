using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class A
    {
        public int x;
        public void getdata(int a)
        {
            x = a;
        }
    }
     interface B
    {
        void getdata1(int b);
    }
    public class C:A,B
    {
        public int y;
        public void getdata1(int b)
        {
            y = b;
        }
        public static void Main(string[] args)
        {
            
            C obj = new C();
            obj.getdata(10);
            obj.getdata1(5);
            Console.WriteLine("The Sum is: " + (x + y));
        }
    }
}
