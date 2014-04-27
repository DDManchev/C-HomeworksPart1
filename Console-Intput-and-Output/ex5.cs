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
            Console.Write("Number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Number b: ");
            int b = int.Parse(Console.ReadLine());

            int max = Math.Max(a, b);

            Console.WriteLine("The Greater number is {0}", max);
        }
    }
}
