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
            int n = Int32.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            string res = "";
            if (n == 0)
            {
                Console.WriteLine("Please enter number greater than or equal to 1");
            }
            else if (n >= 1)
            {
                if (n == 1)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("0,1");
                }
                int sum = 1;
                for (var i = 2; i < n; i++)
                {

                    var f = f1 + f2;
                    f1 = f2;
                    f2 = f;
                    res += ", " + f;
                    sum += f;
                }
                if (n != 1)
                    res += "<br/> The Sum is " + sum;
            }
        }
    }
}
