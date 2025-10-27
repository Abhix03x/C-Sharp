using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Const_digit
    {
        public Const_digit() {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int len = n.ToString().Length;
            int sum = 0;

            while (len != 0)
            {
                int digit = n % 10;

                sum += digit;
                n /= 10;
                len--;

            }
            Console.WriteLine($"{sum}");
        }
    }
}
