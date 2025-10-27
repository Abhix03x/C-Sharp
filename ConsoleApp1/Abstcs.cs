using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    abstract class Ab
    {
        public void display()
        {
            Console.WriteLine("non abs methode");
        }
        public abstract void abmethod();
    }
    internal class Abstcs:Ab
    {
        public override void abmethod()
        {
            Console.WriteLine("abstract method");
        }
    }
}
