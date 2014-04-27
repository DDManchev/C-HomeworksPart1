using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = @"The ""use"" of quotations causes difficulties.";
            string str2 = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
