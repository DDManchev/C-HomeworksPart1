using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstVal = Convert.ToInt32(Console.ReadLine());
            int secondVal = Convert.ToInt32(Console.ReadLine());
            int thirdVal = Convert.ToInt32(Console.ReadLine());
            if (firstVal >= secondVal)
            {
                if (firstVal >= thirdVal)
                {
                    Console.WriteLine( firstVal);
                }
                else
                {
                    Console.WriteLine(thirdVal);
                }

            }
            else
            {
                if (secondVal >= thirdVal)
                {
                    Console.WriteLine(secondVal);
                }
                else
                {
                    Console.WriteLine(thirdVal);
                }
            }
        }
    }
}
