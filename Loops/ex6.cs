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
            double n = Double.Parse(Console.ReadLine());
            double x = Double.Parse(Console.ReadLine());
            double faktN = 1;
            double pow = 1;
            double sumX = 1;
            for (var i = 1; i <= n; i++)
            {
                faktN *= i;
                pow = Math.Pow(x, i);
                sumX += faktN / pow;
            }
            Console.WriteLine("The result is: " + sumX);
        }
    }
}
