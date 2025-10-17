using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pattern
    {
        public void pattern()
        {
            int n = 4;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public void pattern1()
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }
        public void pattern2()
        {
            int n = 4;
            int num = 1;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                }
                Console.WriteLine();
            }
        }
        public void pattern3()
        {
            int n = 4;
            for(int i = n; i >= 1; i--)
            {
                for(int j = 1;j <= i; j++)
                {
                    Console.Write(i +" ");
                }
                Console.WriteLine();
            }
        }
        public void pattern4()
        {
            int n = 4;
            
            for(int i = n;i >= 1; i--)
            {
                int num = 1;
                for ( int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num += 2;
                }
                Console.WriteLine();
            }
        }

    }
}
