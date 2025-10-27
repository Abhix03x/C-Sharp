using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C
{
    internal class HashTableeg
    {
        public void hashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "sunday");
            ht.Add("2", "monday");
            ht.Add("3", "tuesday");
            Console.WriteLine(ht["2"].ToString());
            if (ht.ContainsValue("monday"))
            {
                Console.WriteLine("find value");
            }
            else
            {
                Console.WriteLine("not found");
            }
            if (ht.ContainsKey("3"))
            {
                Console.WriteLine("find key");
            }
            else
            {
                Console.WriteLine("not found");
            }
            foreach (DictionaryEntry e in ht) { 
                Console.WriteLine(e.Key+"_"+e.Value);
            }
            ht.Remove("3");
            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine(e.Key + "_"+e.Value);
            }
        }
    }
}
