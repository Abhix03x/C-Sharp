using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Heirar_inh
    {
        public class A1
        {
            protected int a, b;
            public void read()
            {
                Console.WriteLine("enter the number");
                 a = Convert.ToInt32(Console.ReadLine());
                 b = Convert.ToInt32(Console.ReadLine());
            }

        }
        public class A2:A1
        {
            public void sum()
            {
                int sum = a + b;
                Console.WriteLine($"The sum is {sum}" );
            }
        }
        public class A3:A1
        {
            public void product()
            {
                int p = a * b;
                Console.WriteLine($"the product is {p}");
            }
        }
    }
}
