using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = 5.6666666666666666666666666M;
            decimal number2 = 6.01M;
            decimal roundednum1 = Math.Round(number1, 6);
            decimal roundednum2 = Math.Round(number2, 6);
            if (roundednum1 == roundednum2)
            {
                Console.WriteLine("The numbers are equal");
            }
            else if (roundednum1 > roundednum2)
            {
                Console.WriteLine("Number1 is bigger than Number2");
            }
            else
            {
                Console.WriteLine("Number2 is bigger than Number1");
            }
            





        }
    }
}
