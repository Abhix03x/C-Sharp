using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Multilv_inh
    {
        public class A1 { 
            public void Work()
            {
                Console.WriteLine("A1 is working");
            }
        }
        public class A2:A1 {
            public void study()
            {
                Console.WriteLine("A2 is studying");
            }
        }
        public class A3 : A2 {
            public void run()
            {
                Console.WriteLine("A3 is running");
            }
        }
    }
}
