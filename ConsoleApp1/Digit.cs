using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Digit
    {
        public Digit() {
            bool continuec = true;
            while (continuec)
            {
                try
                {
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
                    Console.WriteLine("do you want continue (Y/N)");
                    string res = Console.ReadLine().Trim().ToLower();
                    if (res != "y")
                    {
                        continuec = false;
                        Console.WriteLine("exited");
                    }

                }
                catch (Exception e) {
                    Console.WriteLine($"an error occured: {e.Message} ");
                }
            }
        }
    }
}
