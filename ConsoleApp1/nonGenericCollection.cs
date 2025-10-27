using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C
{
    internal class nonGenericCollection
    {
        //array list
        public void arrayList()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("hello");
            al.Add(3.14);
            foreach (var item in al) { 
                Console.WriteLine(item);
            }
        }
        //hashtable
        public void hashtable() { 
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            foreach (DictionaryEntry entry in ht) {
                Console.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }
        //Queue
        public void queue()
        {
            Queue q = new Queue();
            q.Enqueue("first");
            q.Enqueue("second");
            Console.WriteLine(q.Dequeue());
        }
        //stack
        public void stack()
        {
            Stack<int> num= new Stack<int>();
            num.Push(1);
            num.Push(2);
            Console.WriteLine(num.Pop());
        }
    }
}
