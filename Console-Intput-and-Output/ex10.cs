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
            decimal startNumber = 1;
            decimal totalSum = 1;
            decimal roundedTotalSum = Math.Round(totalSum, 3);
            Console.WriteLine(startNumber);
            for (decimal j = 2; j <= 1000; j++)
            {
                startNumber = 1;
                if (j % 2 == 0)
                {
                    startNumber = startNumber / j;
                }
                else
                {
                    startNumber = -(startNumber / j);
                }
                Console.WriteLine(startNumber);

                totalSum = totalSum + startNumber;
            }
            Console.WriteLine("The Total sum is: {0}", roundedTotalSum);
        }
    }
}
