using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Transpose
    {
        public void transpose() {
            int i, j;
            Console.WriteLine("enter the rows and column");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("reading elements");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("transpose is");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(a[j, i] + "\t ");
                }
                Console.WriteLine();
            }
        }
    }
}
