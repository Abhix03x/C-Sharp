using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Mul_inh
    {
        interface A1
        {
            void sum(int a,int b);
        }
        interface B1
        {
            int product();
        }
        public class mul_inh :A1,B1 {
            public void sum(int a, int b) {
                int c = a + b;
                Console.WriteLine($"Sum = "+c);
            }
            public int product() {
                int a, b;
                Console.WriteLine("enter the two numbers");
                a=Convert.ToInt32(Console.ReadLine());
                b=Convert.ToInt32(Console.ReadLine());
                return a*b;
            }
        }
    }
}
