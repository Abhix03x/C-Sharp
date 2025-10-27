using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Inheritance
    {
        public class parent()
        {
            public void msg()
            {
                Console.WriteLine("parent says hello!!");
            }

        }
        public class child : parent {
            public void reply()
            {
                Console.WriteLine("child says hai!!");
            }
        }

    }
}
