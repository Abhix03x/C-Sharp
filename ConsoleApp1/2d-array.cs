using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoD_Array
    {
        public void _2d()
        {
            int i, j;
            Console.WriteLine("enter the rows and column");
            int m=Convert.ToInt32(Console.ReadLine());
            int n=Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("reading array");
            for (i = 0; i < m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the array");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
