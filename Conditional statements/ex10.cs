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
            int a = Int32.Parse(Console.ReadLine());
            if ((a < 1) || (a > 9))
            {
                Console.WriteLine(" enter value from 1 to 9 ");
            }
            if ((a >= 1) && (a <= 4))
            {
                Console.WriteLine(10 * a);
            }
            else if ((a >= 5) && (a <= 6))
            {
                Console.WriteLine(100 * a);
            }
            else if ((a >= 7) && (a <= 9))
            {
                Console.WriteLine(1000 * a);
            }
        }
    }
}
