using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());
            int faktK = 1;
            int faktN = 1;
            int prod = 1;
            int faktK_N = 1;
            while (n != 0)
            {
                faktN *= n;
                n--;
            }
            while (k != 0)
            {
                faktK *= k;
                k--;
            }
            while ((k != 0) && (n != 0))
            {
                faktK_N *= (k - n);
                k--;
                n--;
            }

            prod = faktN * (faktK / faktK_N);
            Console.WriteLine("The result is: " + prod);
        }
    }
}
