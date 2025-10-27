using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("base class virtual method");
        }
    }
    internal class Fun_ovr:A
    {
        public override void display()
        {
            Console.WriteLine("derived class method");
        }
    }
}
