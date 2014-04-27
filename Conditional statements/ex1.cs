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
            Console.Write("Enter first value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int swap = 0;
            if (a > b)
            {
                swap = a;
                a = b;
                b = swap;
                Console.WriteLine("a and b are: {0} and {1}",a,b);
            }
            else
            {
                Console.WriteLine("It's not bigger than the first.");
            }
        }
    }
}
