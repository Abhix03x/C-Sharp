using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aarray
    {
        public void search()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the element to search");
            int p = int.Parse(Console.ReadLine());
            bool flag = false;
            int ind = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == p)
                {
                    flag = true;
                     ind = i;
                }
            }
            if (flag)
            {
                Console.WriteLine($"element found at index {ind}");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
        public void sum()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0;i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"the sum is {sum}");
        }


    }
}