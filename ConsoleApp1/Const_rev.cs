using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Const_rev
    {
       public Const_rev()
        {
            Console.WriteLine("enter no ");
            int n = int.Parse(Console.ReadLine());
             int rev = 0;
            do
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            } while (n != 0);
            Console.WriteLine($"the reverse is {rev}");
        } 
    }
}
