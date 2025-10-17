using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Numb
    {
        public void multiple()
        {
            int mul5 = 0, mul3 = 0;
            Console.WriteLine("enter the range");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    mul3 += i;
                    mul5 += i;
                }
                else if (i % 5 == 0) {
                    mul5 += i;
                }
                else if (i % 3 == 0)
                {
                    mul3 += i;
                }
            }
            Console.WriteLine($"the sum of multiple of 3 and 5 in the given range is {mul3} and {mul5}"); 
        }
        public void interchange() {
            Console.WriteLine("enter num 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"the numbers before swapping a {a} b {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"after a {a} b {b}");
        }
        public void swap()
        {
            Console.WriteLine("enter num 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num 2");
            int b = int.Parse(Console.ReadLine());
            int c;
            Console.WriteLine($"the numbers before swapping a {a} b {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"after a {a} b {b}");
        }
        public void arms()
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int len = n.ToString().Length;
            int temp = n;
            int sum = 0;
            while (temp != 0)
            {
                int digit = temp % 10;
                int pow = (int)Math.Pow(digit, len);
                sum += pow;
                temp /= 10;

            }
            Console.WriteLine($"{sum}");
            if(sum == n)
            {
                Console.WriteLine($"{n} is armstrong");
            }
            else
            {
                Console.WriteLine($"{n} is not armstrong");
            }

        }
        public void sumrange() {
            Console.WriteLine("enter the range from");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the range to");
            int s = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = n; i <= s; i++) {
                sum += i;
            }
            Console.WriteLine($"the sum of elements in the given range is {sum}");
        }
        
    }
    
}

