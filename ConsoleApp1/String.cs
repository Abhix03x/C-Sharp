using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Globalization;

    internal class Sstring
    {

        public void fibonacci()
        {
            Console.WriteLine("enter no of terms");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.WriteLine("fibonacci series");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a+" ");
                c = a + b;
                a = b;
                b = c;
            }
        }
        public void prime()
        {
            Console.WriteLine("enter no ");
            int n = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i < n; i++) {
                if (n % i == 0) { 
                    isprime = false;
                    break;
                }
            }
            if (isprime) { 
                Console.WriteLine($"{n} is prime");
            }
            else { Console.WriteLine($"{n} is mot prime"); }
        }
        public void factorial()
        {
            Console.WriteLine("enter no ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i < n; i++) {
                fact *= i;
            }
            Console.WriteLine($"factorial of {n} is {fact}");

        }
        public void reverse()
        {
            Console.WriteLine("enter no ");
            int n = int.Parse(Console.ReadLine());
            int rev = 0;
            do
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n/=10;
            }while ( n != 0 );
            Console.WriteLine($"the reverse is {rev}");
        }
        public void multable()
        {
            Console.WriteLine("enter no ");
            int n = int.Parse(Console.ReadLine());
            int i =1;
            while (i <= 10)
            {
                Console.WriteLine($"{n} * {i} = {n * i}"); i++;
            }
        }
        public void palindrome()
        {
            Console.WriteLine("enter no ");
            int n = int.Parse(Console.ReadLine());
            int o = n;
            int rev = 0;
            do
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            } while (n != 0);
            if (o == rev) { Console.WriteLine("the number is palindrome"); }
            else { Console.WriteLine("not palindrome"); }

        }
    }
}
