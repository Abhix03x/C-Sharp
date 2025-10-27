using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Calculator
    {
        public  Calculator()
        {
            bool continueo = true;
            while (continueo)
            {
                try
                {
                    Console.WriteLine("Simple Calculator");
                    Console.WriteLine("enter the number 1 :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the number 2 :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the operator (+,-,*,/)");
                    char n = Convert.ToChar(Console.ReadLine());
                    switch (n)
                    {
                        case '+':
                            Console.WriteLine($"Sum =" + (a + b));
                            break;
                        case '-':
                            Console.WriteLine($"Difference =" + (a - b));
                            break;
                        case '*':
                            Console.WriteLine($"product =" + (a * b));
                            break;
                        case '/':
                            if (b != 0)
                            {
                                Console.WriteLine("Division = " + ((float)a / b));
                            }
                            else { Console.WriteLine("Error division by zero"); }
                            break;
                        default :
                            Console.WriteLine("invalid input");
                            break;
                    }
                    Console.WriteLine("do tou want to perform another operation(Y/N)");
                    string s = Console.ReadLine().Trim().ToLower();
                    if (s != "y")
                    {
                        continueo = false;
                        Console.WriteLine("Good bye !!!");
                    }
                }catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }
    }
}
