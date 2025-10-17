using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arraysum
    {
        public void sum()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"the sum is {sum}");
        }
    }
}
