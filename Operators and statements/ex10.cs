using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = ParseInt(Console.ReadLine());
            int p = ParseInt(Console.ReadLine());
            bool isOne = false;
            int mask = 1 << p;
            int res = v & mask;
            if ((res >>= p) == 1)
            {
                isOne = true;
                Console.WriteLine(isOne);
            }
            else
            {
                Console.WriteLine(isOne);
            }

        }
    }
}
