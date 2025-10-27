using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    sealed class s
    {
        public void display()
        {
            Console.WriteLine("sealed class");

        }
    }
    internal class Sealed
    { 
        public void run()
        {
            s n =new s();
            n.display();
            Console.ReadKey();
        }
    }
}
