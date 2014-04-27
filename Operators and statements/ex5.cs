using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = ParseInt(Console.ReadLine());
            int mask = 1 << 3;
            int res = a & mask;
            int res = res >> 3;
            Console.WriteLine(res);
        }
    }
}
