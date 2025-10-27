using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Fun_ovl
    {
        public int a, b, c;
        public void sum()
        {
            Console.WriteLine("enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine($"the sum is {c}");
        }
        public int sum(int a, int b) { 
            return a + b;
        }
        public double sum(double a, double b) {
            return (a + b);
        }
    }
}
