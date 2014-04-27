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
            int x = Int32.Parse(Console.ReadLine());
            for (var i = 1; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
