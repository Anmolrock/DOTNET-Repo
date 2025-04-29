using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalFile
{
    class Example
    {
        public  void array<T>(T[] a)
        {
            for (int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
    class Program14
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            string[] Names = { "Anmol", "Deepak", "Anand" };
            double[] Points = { 2.5, 1.5, 3.6, 5.8 };
            Example obj = new Example();
            obj.array(arr);
            obj.array(Names);
            obj.array(Points);
            Console.ReadLine();
        }
    }
}
