using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Const_calc
    {
        public Const_calc()
        {
            Console.WriteLine("enter the numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter choice");
            Console.WriteLine("1.Add\n2.Sub\n3.Mul\n4.Div");
            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            switch (choice)
            {
                case 1:
                    result = Simple_calc.add(n, m); break;
                case 2:
                    result = Simple_calc.sub(n, m); break;
                case 3:
                    result = Simple_calc.mul(n, m); break;
                case 4:
                    result = Simple_calc.div(n, m); break;
                default:
                    Console.WriteLine("enter a valid option");
                    break;
            }
            Console.WriteLine($"Result :{result}");
        }
        public double add(int x, int y)
        {
            return x + y;
        }
        public double sub(int x, int y)
        {
            return x - y;
        }
        public  double mul(int x, int y)
        {
            return x * y;
        }
        public double div(int x, int y)
        {
            return x / y;
        }
    }
        
    
    }

    

