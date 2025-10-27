using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C
{
    internal class ArrayListeg
    {
        public void arrayList()
        {
            int i = 0;
            ArrayList item = new ArrayList();
            item.Add("item 1");
            item.Add("item 2");
            item.Add("item 5");
            item.Add("item 9");
            Console.WriteLine("the added items are");
            for (i = 0; i < item.Count; i++) { 
                Console.WriteLine(item[i].ToString());
            }
            item.Insert(3, "item 6");
            Console.WriteLine("the added items are");
            for (i = 0; i < item.Count; i++)
            {
                Console.WriteLine(item[i].ToString());
            }
            item.Remove("item 1");
            Console.WriteLine("the added items are");
            for (i = 0; i < item.Count; i++)
            {
                Console.WriteLine(item[i].ToString());
            }
            item.RemoveAt(3);
            Console.WriteLine("the added items are");
            for (i = 0; i < item.Count; i++)
            {
                Console.WriteLine(item[i].ToString());
            }

        }
    }
}
