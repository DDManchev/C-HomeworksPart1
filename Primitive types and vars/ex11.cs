using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int swap;
            swap = a;
            a = b;
            b = swap;
            Console.WriteLine("The value of \" a \" is {0} and the value of \" b \" is {1}", a, b);
        }
    }
}
