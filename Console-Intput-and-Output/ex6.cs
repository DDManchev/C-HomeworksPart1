using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Input_and_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("This is not an quadratic equation!");
            }
            else
            {
                double disc = (b * b) - (4 * a * c);
                if (disc > 0)
                {
                    double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                    Console.WriteLine("The equation roots are:nX1: {0}nX2: {1}", x1, x2);
                }
                else if (disc == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("The equaltion has only one root: {0}", x);
                }
                else if (disc < 0)
                {
                    Console.WriteLine("This equations doesn't have solution!");
                }
            }
        }
    }
}
