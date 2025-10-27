using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class Parametrized
    {
        public static int sum(params int[] arr)
        {
            int s=0,i;
            for (i = 0; i < arr.Length; i++) {
                s += arr[i];
            }
            return s;
        }
    }
}
