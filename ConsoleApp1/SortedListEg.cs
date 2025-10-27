using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C
{
    internal class SortedListEg
    {
        public void sortedlist()
        {
            SortedList sl = new SortedList();
            sl.Add("one", "1");
            sl.Add("two", "2");
            sl.Add("three", "3");
            sl.Add("four", "4");
            for (int i = 0; i < sl.Count; i++) { 
                Console.WriteLine("Key:{0},value{1}",sl.GetKey(i),sl.GetByIndex(i));
            }
            Console.WriteLine(sl.Contains("one"));
            Console.WriteLine(sl.Contains("2"));
            Console.WriteLine(sl.ContainsKey("four"));
            Console.WriteLine(sl.ContainsValue("two"));
        }
    }
}
