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
            decimal a = 1;
            decimal b = 0;
            decimal c = 0;

            for (int i = 0; i <= 100; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(i + ": " + c);
            }
        }
    }
}
