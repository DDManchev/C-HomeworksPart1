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
            Console.Write("Number x : ");
            int numberx = int.Parse(Console.ReadLine());
            Console.Write("Number y : ");
            int numbery = int.Parse(Console.ReadLine());

            for (int i = numberx; i <= numbery; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
