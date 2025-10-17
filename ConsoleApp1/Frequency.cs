using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Frequency
    {
        public void frequency() {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Dictionary<int,int> freq = new Dictionary<int,int>();
            foreach (int num in arr) { 
                if(freq.ContainsKey(num)) 
                    freq[num]++;
                else
                    freq[num] = 1;

            }
            Console.WriteLine("frequency of nums are");
            foreach (var pair in freq) {
                if (pair.Value > 1)
                {
                    Console.WriteLine($"{pair.Key}:{pair.Value}");
                }
            }
        }
    }
}
