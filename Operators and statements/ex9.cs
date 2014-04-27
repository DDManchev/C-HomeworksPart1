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

            
            int radius = 9;
            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= (radius))
            {
                Console.WriteLine("The point is in the circle");
            }
            else
            {
                Console.WriteLine("The point is outside the circle");
            }
            if ((x < -1) || (x >= -1) && ((y <= -1) || (y >= 1)))
            {
                Console.WriteLine("The point is outside the rectangle");
            }
            else
            {
                Console.WriteLine("The point is outside the rectangle");
            }
        }
    }
}
