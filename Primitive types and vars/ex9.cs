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
            char str2 = '©';
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(@"                               {0}
                            {0}    {0}
                          {0}       {0}
                        {0}           {0}
                       {0}{0}{0}{0}{0}{0}{0}{0}", str2);
            
        }
    }
}
