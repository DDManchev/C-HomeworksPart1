using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double disc = b * b - 4 * a * c;
            double x0 = -b / 2 * a;
            double x1 = (-b + Math.Sqrt(disc)) / 2 * a;
            double x2 = (-b - Math.Sqrt(disc)) / 2 * a;
            if (disc < 0)
            {
                Console.WriteLine("Няма реални корени");
            }
            else if (disc == 0)
            {
                Console.WriteLine("Има един реален корен: " + x0);
            }
            else if (disc > 0)
            {
                Console.WriteLine("Има два реални корена - х1:" + x1 + " и х2: " + x2);
            }
        }
    }
}
