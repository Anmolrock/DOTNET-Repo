using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==> Example-1//
            /*int[] array = new int[5];
            {
                array[0] = 1;
                array[1] = 2;
                array[2] = 3;
                array[3] = 4;
                array[4] = 5;
            }
            for(int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();*/

            //==> Example-2//
            int[,] array = new int[3, 3]
            {
                {12,24,36},
                {13,26,39},
                {14,28,52}
            };  

            for (int i = 0; i< array.GetLength(0); i++)
            {
                for(int j=0; j< array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]+ "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
