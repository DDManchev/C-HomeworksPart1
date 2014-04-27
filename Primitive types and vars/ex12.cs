using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            for (int i = 0; i < 255; i++)
            {
                char symbol = (char)i;
                Console.WriteLine("Symbol, corresponding to the number {0} is {1}", i, symbol);
            }
        }
    }
}
