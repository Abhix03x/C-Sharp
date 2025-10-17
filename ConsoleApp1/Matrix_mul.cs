using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Matrix_mul
    {
        public void mul()
        {
            int i, j, k;
            Console.WriteLine("enter the rows and column of matrix1");
            int r1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the rows and column of matrix2");
            int r2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());

            int[,] m1 = new int[r1, c1];
            int[,] m2 = new int[r2, c2];
            int[,] rslt = new int[r1, c2];

            if (c1 != r2)
            {
                Console.WriteLine("Matrix multiplication not possible");
            }
            else
            {
                Console.WriteLine("enter matrix1");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        m1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("enter matrix2");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        m2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("the matrixes ");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write(m1[i, j]);
                    }
                    Console.WriteLine();
                }
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write(m2[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("multiplying");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        rslt[i, j] = 0;

                        for (k = 0; k < r2; k++)
                        {
                            rslt[i, j] += m1[i, k] * m2[k, j];
                        }
                    }
                }
                Console.WriteLine("resultant matrix");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write(rslt[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
