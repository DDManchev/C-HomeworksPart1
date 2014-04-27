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
            int x = ParseInt(Console.ReadLine());
            int y = ParseInt(Console.ReadLine());
            int r = 5;
            int z = ((x * x) + (y * y));
            if (z < (r * r))
            {
                Console.WriteLine("точката е вътре в кръга");
            }
            else if (z == (r * r))
            {
                Console.WriteLine("Точката е на кръга");
            }
            else
            {
                Console.WriteLine("точката е извън кръга");
            }
        }
    }
}
