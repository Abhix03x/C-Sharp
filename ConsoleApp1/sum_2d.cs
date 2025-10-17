using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Matrix_sum
    {
        public void sum()
        {
            int i,j;
            Console.WriteLine("enter the rows and column");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] m1 = new int[m,n];
            int[,] m2 = new int[m,n];
            int[,] rslt = new int[m,n];

            Console.WriteLine("enter matrix1");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("enter matrix2");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    m2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the sum is ...");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    rslt[i,j] = m1[i,j] + m2[i,j];
                
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(rslt[i, j]+ " ");

                }
                Console.WriteLine();
            }
        }
    }
}
