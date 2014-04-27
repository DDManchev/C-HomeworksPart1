using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string f1 = "Hello";
            string f2 = "World!";
            object f3 = f1 + " " + f2;
            string f4 = (string)f3;
            Console.WriteLine(f4);
        }
    }
}
